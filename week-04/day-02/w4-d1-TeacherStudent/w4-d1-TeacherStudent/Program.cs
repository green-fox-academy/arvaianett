using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_d1_TeacherStudent
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Teacher teacher1 = new Teacher();

            Console.WriteLine(teacher1.Teach(student1));
            Console.WriteLine(student1.Question(teacher1));

            Console.ReadLine();
        }
    }
}
