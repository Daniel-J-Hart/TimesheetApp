using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimesheetApp.AllForms;
using TimesheetApp.Data;
using TimesheetApp.Helpers;
using TimesheetApp.Models;
using Newtonsoft.Json;
using System.IO;

namespace TimesheetApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOpenSummary_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm(this);
            summaryForm.Show();

            this.Hide(); // Hide the main form when opening the summary form (keeps Form1 in memory instead of .Close() which closes it)

        }

        private void BtnAddEntry_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployee.Text.Trim();
            string jobName = txtJob.Text.Trim();
            DateTime workDate = dtpWorkDate.Value.Date;
            decimal hoursWorked = (Decimal)numHoursWorked.Value;

            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(jobName))
            {
                MessageBox.Show("Please enter both employee and job names.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hoursWorked > 10)
            {
                EmailHelper.SendEmail(employeeName, hoursWorked, workDate);
            }

            var data = DatabaseHelper.LoadData();

            // Employee Logic
            var employee = data.Employees.FirstOrDefault(emp => emp.Name.Equals(employeeName, StringComparison.OrdinalIgnoreCase));
            if (employee == null)
            {
                employee = new Employee
                {
                    EmployeeId = data.Employees.Count + 1,
                    Name = employeeName,
                    Email = employeeName.ToLower() + "@wefengineering.com" // Example email
                };
                data.Employees.Add(employee);
            }

            // Job Logic
            var job = data.Jobs.FirstOrDefault(j => j.JobName.Equals(jobName.Trim(), StringComparison.OrdinalIgnoreCase));
            if (job == null)
            {
                job = new Job
                {
                    JobId = data.Jobs.Count + 1,
                    JobName = jobName,
                    TotalHours = 0
                };
                data.Jobs.Add(job);
            }

            // Timesheet Logic
            var timesheet = new Timesheet
            {
                TimesheetID = data.Timesheets.Count + 1,
                EmployeeId = employee.EmployeeId,
                JobId = job.JobId,
                WorkDate = workDate,
                HoursWorked = hoursWorked
            };
            data.Timesheets.Add(timesheet);

            // Update job total hours
            job.TotalHours += (decimal)hoursWorked;

            // Save
            DatabaseHelper.SaveData(data);
            MessageBox.Show("Timesheet entry added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
