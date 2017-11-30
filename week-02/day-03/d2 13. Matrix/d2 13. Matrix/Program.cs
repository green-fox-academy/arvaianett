using System;

namespace d2_13._Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4] { { 1, 0, 0, 0}, { 0, 1, 0, 0}, { 0, 0, 1, 0}, { 0, 0, 0, 1} };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array [i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
