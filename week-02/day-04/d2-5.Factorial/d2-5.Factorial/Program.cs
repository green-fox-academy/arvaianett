using System;

namespace d2_5.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorio(number));
            
            Console.ReadLine();
        }

        static int Factorio(int factorial)
        {
            int numb = 1;

            for (int i = 1; i <= factorial; i++)
            {
                numb *= i;
            }

            return numb;
        }
    }
}
