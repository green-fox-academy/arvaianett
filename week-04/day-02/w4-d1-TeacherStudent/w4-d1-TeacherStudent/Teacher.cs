using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_d1_TeacherStudent
{
    public class Teacher
    {
        public string Answer { get; set; }
        public string Teachh { get; set; }

        public string Teach(Student s)
        {
            return Teachh = s.Learnn();
        }

        public string Answers()
        {
            return Answer = $"4";
        }
    }
}
