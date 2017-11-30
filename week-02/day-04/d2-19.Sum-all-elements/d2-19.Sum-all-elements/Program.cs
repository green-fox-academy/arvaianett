using System;

namespace d2_19.Sum_all_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = { 3, 4, 5, 6, 7 };

            int sum = ai[0]+ ai[1] + ai[2] + ai[3] + ai[4];

            Console.WriteLine(sum);

            int summary = 0;
            for (int i = 0; i < 5; i++)
            {
                summary += ai[i];
            }
            Console.WriteLine(summary);
            Console.ReadLine();
        }
    }
}
