using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int bunnies = 5;
            int counter = 0;

            Console.WriteLine(Ears(bunnies, counter));
            
            Console.ReadLine();
        }
        static int Ears(int bunnies, int counter)
        {
            if (bunnies == 0)
            {              
                return counter;
            }
            else
            {
                if(bunnies % 2 == 0)
                {
                    Ears(--bunnies, counter += 3);
                }
                else if(bunnies % 2 != 0)
                {
                    Ears(--bunnies, counter += 2);
                }
                return Ears(bunnies, counter);
            }
        }
    }
}
