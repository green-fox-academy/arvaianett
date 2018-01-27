using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long TeamId { get; set; }
        public long ClassId { get; set; }
    }
}
