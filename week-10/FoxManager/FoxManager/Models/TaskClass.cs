using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class TaskClass
    {
        public long Id { get; set; }
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        public string PriorityLevel { get; set; }

        public Student Student { get; set; }
        public Team Team { get; set; }
    }
}
