using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 136;

            Console.WriteLine(Sum(number));
            Console.ReadLine();
        }
        static int Sum(int number)
        {
            if (number < 10)
            {
                return number;
            }
            else
            {                              
                return number % 10 + Sum(number / 10);               
            }
        }
    }
}
