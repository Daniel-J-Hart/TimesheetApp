using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetApp.Models
{
    internal class summaryreport
    {
        public DateTime WorkDate { get; set; }
        public string EmployeeName { get; set; }
        public string JobName { get; set; }
        public int HoursWorked { get; set; }
    }
}
