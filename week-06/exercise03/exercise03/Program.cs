using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> squaredPosList = n.Where(x => x > 0)
                .Select(x => x * x);

            foreach (int numbers in squaredPosList)
            {
                Console.WriteLine(numbers);
            }

            IEnumerable<int> squaredPostListQuery =
                from number in n
                where number > 0
                select number * number;

            foreach (int number in squaredPostListQuery)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
