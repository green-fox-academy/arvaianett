using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyMethod = n.OrderByDescending(x => x)
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());

            foreach (var item in frequencyMethod)
            {
                Console.WriteLine(item);
            }

            var frequencyQuery =
                from number in n
                orderby number
                group number by number into a
                select a;
            Dictionary<int, int> dictionary = frequencyQuery.ToDictionary(y => y.Key, y => y.Count());

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
