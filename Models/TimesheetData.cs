using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetApp.Models
{
    internal class TimesheetData
    {
        public List<Employee> Employees { get; set; }
        public List<Job> Jobs { get; set; }
        public List<Timesheet> Timesheets { get; set; }

    }
}
