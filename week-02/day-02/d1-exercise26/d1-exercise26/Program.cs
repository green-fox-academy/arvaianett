using System;

namespace d1_exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first number: ");
            string first = Console.ReadLine();

            Console.WriteLine("second number: ");
            string second = Console.ReadLine();

            if (int.Parse(second) < int.Parse(first))
            {
                Console.WriteLine("The second number should be bigger");
            }

            for (int i = int.Parse(first); i < int.Parse(second); i++)
            {
                if (int.Parse(second) > int.Parse(first))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
