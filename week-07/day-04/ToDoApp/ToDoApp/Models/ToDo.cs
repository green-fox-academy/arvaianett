using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public string Task { get; set; }
        public bool Done { get; set; }
        public bool Urgent { get; set; }
        public int Number { get; set; }
    }
}
