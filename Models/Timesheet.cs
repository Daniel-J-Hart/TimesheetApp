using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetApp.Models
{
    internal class Timesheet
    {
        public int TimesheetID { get; set; }
        public int EmployeeId { get; set; }
        public int JobId { get; set; }
        public DateTime WorkDate { get; set; }
        public decimal HoursWorked { get; set; }
    }
}
