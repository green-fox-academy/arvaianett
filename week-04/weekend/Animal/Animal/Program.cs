using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalClass animal1 = new AnimalClass();

            animal1.Eat(2);

            Console.WriteLine(animal1.hunger);
            Console.ReadLine();
        }
    }
}
