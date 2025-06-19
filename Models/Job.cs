using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetApp.Models
{
    internal class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public Decimal TotalHours { get; set; }
    }
}
