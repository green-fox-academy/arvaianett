using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Models
{
    public class Class
    {
        public long Id { get; set; }
        public string ClassName { get; set; }
        public string Technology { get; set; }

        public List<Student> Students { get; set; }
    }
}
