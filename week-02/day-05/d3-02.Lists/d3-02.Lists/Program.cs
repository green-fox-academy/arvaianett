using System;
using System.Collections.Generic;

namespace d3_02.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string> { girls[0], boys[0], girls[1], boys[1], girls[2], boys[2],
                                           girls[3], boys[3], girls[4], boys[4], boys[5] };

            foreach (var o in order)
            {
                Console.WriteLine(o);
            }

            Console.ReadLine();
        }
    }
}
