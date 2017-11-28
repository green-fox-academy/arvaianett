using System;

namespace d1_exercise35
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 9; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(" % % % %  ");
                }
                if (i % 2 == 1)
                {
                    Console.WriteLine("  % % % % ");
                }
            }
            Console.ReadLine();
        }
    }
}
