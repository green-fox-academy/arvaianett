using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4_04.Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            int p = 3;
                        
            Console.WriteLine(Power(number, p));
            Console.ReadLine();
        }
        static int Power(int number, int p)
        {
            if (p == 1)
            {
                return number;
            }
            else
            {           
                return number * Power(number, --p);               
            }
        }
    }
}
