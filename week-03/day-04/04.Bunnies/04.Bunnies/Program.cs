using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int bunnies = 4;

            Console.WriteLine(Ears(bunnies));

            Console.ReadLine();
        }
        static int Ears(int bunnies)
        {
            if (bunnies == 0)
            {
                return 0;
            }
            else
            {
                return Ears(--bunnies) + 2;
            }
        }
    }
}
