﻿using System;

namespace d2_10._Change_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[6]
            {
                1, 2, 3, 8, 5, 6
            };

            s[3] = 4;

            Console.WriteLine(s[3]);
            Console.ReadLine();
        }
    }
}
