using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Windows.Forms;

namespace TimesheetApp.Helpers
{
    internal class EmailHelper
    {
        public static void SendEmail(string employeeName, decimal HoursWorked, DateTime workDate)
        {
            string toEmail = ConfigurationManager.AppSettings["ManagerEmail"];
            string fromEmail = ConfigurationManager.AppSettings["SmtpEmail"];
            string smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
            int smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
            string smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];

            string subject = "Timesheet Alert: Excessive Work Hours";
            string body = $"Employee {employeeName} has logges {HoursWorked} hours on {workDate: dd/MM/yyyy}.";

            MailMessage mail = new MailMessage(fromEmail, toEmail, subject, body);

            using (SmtpClient client = new SmtpClient(smtpHost, smtpPort))
            {
                client.Credentials = new NetworkCredential(fromEmail, smtpPassword);
                client.EnableSsl = true;
                
                try
                {
                    client.Send(mail);
                    MessageBox.Show("Email sent successfully.", "Email Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
