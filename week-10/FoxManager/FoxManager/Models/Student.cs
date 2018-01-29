using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Team Team { get; set; }
        public Class Class { get; set; }
        public List<TaskClass> Tasks { get; set; }
    }
}
