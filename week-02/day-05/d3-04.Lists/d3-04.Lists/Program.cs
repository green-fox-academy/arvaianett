using System;
using System.Collections.Generic;

namespace d3_04.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            list[1] = "Croissant";
            list[3] = "Ice cream";

            foreach (var l in list)
            {
                Console.WriteLine(l);
            }
            Console.ReadLine();
        }
    }
}
