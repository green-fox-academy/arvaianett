using System;

namespace d1_exercise25
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " * " + number + " = " + (i * int.Parse(number)));
            }

            Console.ReadLine();
        }
    }
}
