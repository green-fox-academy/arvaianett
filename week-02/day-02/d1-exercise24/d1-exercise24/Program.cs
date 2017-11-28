using System;

namespace d1_exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 500; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
