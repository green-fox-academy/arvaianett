using System;

namespace d2_16._Append_a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimals = { "kuty", "macsk", "cic" };
            Letter(nimals);
            Console.ReadLine();
        }

        static void Letter(string[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] += "a";
                Console.WriteLine(animals[i]);
            }
        }
    }
}
