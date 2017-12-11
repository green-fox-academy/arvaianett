using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();

            animal1.hunger = 50;
            animal1.hunger = 50;

            animal1.Eat();

            Console.WriteLine(animal1.hunger);
            Console.ReadLine();
        }
    }
}
