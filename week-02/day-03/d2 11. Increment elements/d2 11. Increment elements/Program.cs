using System;

namespace d2_11._Increment_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[5]
            {
                1, 2, 3, 4, 5
            };

            t[2] = 3 + 1;

            Console.WriteLine(t[2]);
            Console.ReadLine();
        }
    }
}
