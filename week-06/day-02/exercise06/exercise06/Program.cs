using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputArray = input.ToCharArray();

            var frequencyMethod = inputArray.OrderBy(x => x)
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());

            foreach (var item in frequencyMethod)
            {
                Console.WriteLine(item);
            }

            var frequencyQuery =
                from i in input
                orderby i
                group i by i into b
                select b;
            var dictionary = frequencyQuery.ToDictionary(y => y.Key, y => y.Count());

            foreach (var item in frequencyQuery)
            {
                Console.WriteLine(item.Key + " " + dictionary[item.Key]);
            }
            Console.ReadLine();
        }
    }
}
