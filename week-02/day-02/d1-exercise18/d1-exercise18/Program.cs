using System;

namespace d1_exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringnumber = Console.ReadLine();

            if (double.Parse(stringnumber) % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else if (double.Parse(stringnumber) % 2 != 0)
            {
                Console.WriteLine("Odd");
            }

            Console.ReadLine();
        }
    }
}
