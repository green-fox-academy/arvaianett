using System;

namespace d2_20._Reverse_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = { 3, 4, 5, 6, 7 };

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(aj[i]);
            }
            Console.ReadLine();
        }
    }
}
