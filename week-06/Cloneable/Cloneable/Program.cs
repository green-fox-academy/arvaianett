using System;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John Doe", 20, "male", "BME");

            Student johnTheClone = john.Clone() as Student;

            Console.WriteLine(john.Introduce());

            Console.WriteLine(johnTheClone.Introduce());

            Console.ReadLine();
        }
    }
}
