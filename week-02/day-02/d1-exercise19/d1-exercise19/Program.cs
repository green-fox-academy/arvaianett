using System;

namespace d1_exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            if (double.Parse(number) <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (double.Parse(number) == 1)
            {
                Console.WriteLine("One");
            }
            else if (double.Parse(number) == 2)
            {
                Console.WriteLine("Two");
            }
            else if (double.Parse(number) > 2)
            {
                Console.WriteLine("A lot");
            }

            Console.ReadLine();
        }
    }
}
