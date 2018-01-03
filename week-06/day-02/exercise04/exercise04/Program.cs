using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            IEnumerable<double> list = n.Select(x => x * x)
                .Where(x => x > 20)
                .Select(x => Math.Sqrt(x))
                .ToList();

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }

            IEnumerable<double> listQ =
                from number in n
                let anotherNumber = number * number
                where anotherNumber > 20
                select Math.Sqrt(anotherNumber);

            foreach (double number in listQ)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
