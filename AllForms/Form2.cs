using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimesheetApp.Models;
using TimesheetApp.Data;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TimesheetApp.AllForms
{
    public partial class SummaryForm : Form
    {
        private MainForm mainForm;
        public SummaryForm(MainForm callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
            this.WindowState = FormWindowState.Maximized;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            var jsonPath = @"C:\Users\danie\source\repos\TimesheetApp\timesheetData.json";
            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                var data = JsonConvert.DeserializeObject<TimesheetData>(json);

                foreach (var job in data.Jobs)
                { 
                    cmbSummaryJob.Items.Add(job.JobName);
                }
            }
        
            // Set up the DataGridView columns
            DgvSummary.Columns.Clear(); // Clear any existing columns
            DgvSummary.Columns.Add("Employee", "Employee");
            DgvSummary.Columns.Add("Monday", "Monday");
            DgvSummary.Columns.Add("Tuesday", "Tuesday");
            DgvSummary.Columns.Add("Wednesday", "Wednesday");
            DgvSummary.Columns.Add("Thursday", "Thursday");
            DgvSummary.Columns.Add("Friday", "Friday");
            DgvSummary.Columns.Add("Saturday", "Saturday");
            DgvSummary.Columns.Add("Sunday", "Sunday");
            DgvSummary.Columns.Add("Total", "Total Hours");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void cmbSummaryJob_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Check if something is selected
            if (cmbSummaryJob.SelectedItem == null)
                return;


            DgvSummary.Rows.Clear(); // Clear previous results

            string json = File.ReadAllText(@"C:\Users\danie\source\repos\TimesheetApp\timesheetData.json");
            JObject data = JObject.Parse(json);

            string selectedJobName = cmbSummaryJob.SelectedItem.ToString();

            // Get the job ID
            var job = data["Jobs"].FirstOrDefault(j => j["JobName"].ToString() == selectedJobName);

            if (job == null)
            {
                MessageBox.Show($"Job '{selectedJobName}' not found in database.");
                return;
            }

            int JobId = (int)job["JobId"];

            // Get employees  with hours for the selected job
            foreach (var employee in data["Employees"])
            {
                int employeeId = (int)employee["EmployeeId"];
                string name = employee["Name"].ToString();

                var employeeTimesheets = data["Timesheets"].Where(ts => (int)ts["JobId"] == JobId && (int)ts["EmployeeId"] == employeeId);

                double mondayHours = 0, tuesdayHours = 0, wednesdayHours = 0, thursdayHours = 0, fridayHours = 0, saturdayHours = 0, sundayHours = 0;

                foreach (var timesheet in employeeTimesheets)
                {
                    DateTime workDate = DateTime.Parse(timesheet["WorkDate"].ToString());
                    decimal hoursWorked = (decimal)timesheet["HoursWorked"];
                    // Distribute hours based on the day of the week
                    switch (workDate.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            mondayHours += (double)hoursWorked;
                            break;
                        case DayOfWeek.Tuesday:
                            tuesdayHours += (double)hoursWorked;
                            break;
                        case DayOfWeek.Wednesday:
                            wednesdayHours += (double)hoursWorked;
                            break;
                        case DayOfWeek.Thursday:
                            thursdayHours += (double)hoursWorked;
                            break;
                        case DayOfWeek.Friday:
                            fridayHours += (double)hoursWorked;
                            break;
                        case DayOfWeek.Saturday:
                            saturdayHours += (double)hoursWorked;
                            break;
                        case DayOfWeek.Sunday:
                            sundayHours += (double)hoursWorked;
                            break;
                    }
                }
                double totalHours = mondayHours + tuesdayHours + wednesdayHours + thursdayHours + fridayHours + saturdayHours + sundayHours;

                if (totalHours > 0)
                {
                    // Add row with all 9 columns: Employee, Mon-Sun, Total
                    DgvSummary.Rows.Add(name, mondayHours, tuesdayHours, wednesdayHours, thursdayHours, fridayHours, saturdayHours, sundayHours, totalHours);
                }
            }

            // Show messgae if no employees found
            if (DgvSummary.Rows.Count == 0)
            {
                MessageBox.Show($"No employees found for job '{selectedJobName}'.");
            }
        }
    }
}
