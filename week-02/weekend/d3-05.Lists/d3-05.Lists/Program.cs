using System;
using System.Collections.Generic;

namespace d3_05.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            if (List.Contains(7))
            {
                Console.WriteLine("Hoorray");
            }
            else
            {
                Console.WriteLine("Noooooo");
            }
            Console.ReadLine();

            if (List.IndexOf(7) < 0)
            {
                Console.WriteLine("Noooooo");
            }
            else
            {
                Console.WriteLine("Hoorray");
            }

            Console.ReadLine();
        }
    }
}
