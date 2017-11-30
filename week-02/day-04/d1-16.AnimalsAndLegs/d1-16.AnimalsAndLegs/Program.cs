using System;

namespace d1_16.AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of chickens: ");
            int chickens = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of pigs: ");
            int pigs = int.Parse(Console.ReadLine());

            int legs1 = 2;
            int legs2 = 4;

            int all = chickens * legs1 + pigs * legs2;
            
            Console.WriteLine("They have " + all + " legs.");

            Console.ReadLine();
        }
    }
}
