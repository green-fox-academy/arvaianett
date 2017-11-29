using System;

namespace d2_8._Compare_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`
            int[] p1 = new int[3];
            p1[0] = 1;
            p1[1] = 2;
            p1[2] = 3;

            int[] p2 = new int[2];
            p2[0] = 4;
            p2[1] = 5;

            if (p2.Length > p1.Length)
            {
                Console.WriteLine("p2 has more");
            }
            else
            {
                Console.WriteLine("p1 has more");
            }

            Console.ReadLine();
        }
    }
}
