using System;
using System.Collections.Generic;

namespace d3._07.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            string fix01 = list[2];
            string fix02 = list[5];

            list[2] = fix02;
            list[5] = fix01;

            foreach (var a in list)
            {
                Console.Write(a);
            }

            Console.ReadLine();

            for (int i = 0; i < 8; i++)
            {
                list[i] = list[i] + " ";
            }

            foreach (var b in list)
            {
                Console.Write(b);
            }
            Console.ReadLine();            
        }
    }
}
