using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> evenNumberMethod = n.Where(x => x % 2 == 0).ToList();

            foreach (int number in evenNumberMethod)
            {
                Console.Write(number);
            }

            IEnumerable<int> evenNumberQuery =
                from number in n
                where number % 2 == 0
                select number;

            foreach (int number in evenNumberQuery)
            {
                Console.Write(number);
            }

            Console.ReadLine();
        }
    }
}
