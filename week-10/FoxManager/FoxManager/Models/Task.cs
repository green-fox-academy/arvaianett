using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Task
    {
        public long Id { get; set; }
        public int DueDate { get; set; }
        public string PriorityLevel { get; set; }
        public long StudentId { get; set; }
        public long TeamId { get; set; }
    }
}
