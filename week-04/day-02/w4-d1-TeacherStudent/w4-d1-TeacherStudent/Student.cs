using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_d1_TeacherStudent
{
    public class Student
    {
        public string Learn { get; set; }
        public string Questionn { get; set; }

        public string Learnn()
        {
            return Learn = $"2+2";
        }

        public string Question(Teacher t)
        {
            return Questionn = t.Answers();
        }
    }
}
