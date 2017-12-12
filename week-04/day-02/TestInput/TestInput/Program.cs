using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Jane Doe", 30, "female");

            Console.WriteLine(person1.Introduce());
            Console.WriteLine(person1.GetGoal());

            Student student1 = new Student("Jane Doe", 30, "female", "The School of Life");
           
            Console.WriteLine(student1.Introduce());
            Console.WriteLine(student1.GetGoal());

            Mentor mentor1 = new Mentor("Jane Doe", 30, "female", "intermediate");

            Console.WriteLine(mentor1.Introduce());
            Console.WriteLine(mentor1.GetGoal());

            Sponsor sponsor1 = new Sponsor("Jane Doe", 30, "female", "Google");

            Console.WriteLine(sponsor1.Introduce());
            Console.WriteLine(sponsor1.GetGoal());

            Pallida pallida1 = new Pallida("Pallida");

            Console.WriteLine(pallida1.Info());

            Console.ReadLine();
        }
    }
}
