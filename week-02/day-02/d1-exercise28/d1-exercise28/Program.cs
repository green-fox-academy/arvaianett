using System;

namespace d1_exercise28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number: ");
            string number = Console.ReadLine();

            if (int.Parse(number) == int.Parse(number))
            {
                Console.WriteLine("*");
            }
            if (int.Parse(number) > 0 || int.Parse(number) <= 0)
            {
                Console.WriteLine("**");
            }
            if (int.Parse(number) == int.Parse(number) || int.Parse(number) != int.Parse(number))
            {
                Console.WriteLine("***");
            }
            if (int.Parse(number) == 10 || int.Parse(number) != 10)
            {
                Console.WriteLine("****");
            }
            Console.ReadLine();
        }
    }
}
