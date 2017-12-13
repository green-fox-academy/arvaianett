using System;
using System.Collections.Generic;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class SumClass
    {
        public int summary = 0;

        public int Sum(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                summary += list[i];
            }

            return summary;
        }
    }
    
}
