using System;
using System.Collections.Generic;

namespace d3_01.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };

            planetList.Insert(5, "Saturn");

            Console.WriteLine(planetList);

            foreach (string p in planetList)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
}
