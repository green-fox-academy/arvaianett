using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int counter = 0;

            Console.WriteLine(Add(number, counter));
            
            Console.ReadLine();
        }
        static int Add(int number, int counter1)
        {
            if (number == 0)
            {
                return counter1;
            }
            else
            {
                return Add(number - 1, counter1 += number);
            }
        }
    }
}
