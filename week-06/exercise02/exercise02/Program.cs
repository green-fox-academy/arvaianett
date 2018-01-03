using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            int averageNumber = Convert.ToInt16(n.Average());

            Console.WriteLine(averageNumber);

            int averageWithQuery =
                Convert.ToInt16((from number in n
                select number).Average());

            Console.WriteLine(averageWithQuery);

            Console.ReadLine();
        }
    }
}
