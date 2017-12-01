using System;
using System.Collections.Generic;

namespace d3_03.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(far[i] + "a"); 
            }
            Console.ReadLine();
        }
    }
}
