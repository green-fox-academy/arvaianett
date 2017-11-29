using System;

namespace d2_4._Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            double parameter = 10;

            Sum(parameter);
            Console.ReadLine();
        }
        static void Sum(double par)
        {
            double number = 0;
            for (int i = 1; i <= par; i++)
            {
                number += i;
            }
            Console.WriteLine(number);
        }
    }
}
