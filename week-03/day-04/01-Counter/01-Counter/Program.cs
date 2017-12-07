using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());
            Count(number);
            Console.ReadLine();
        }
        public static int Count(int number)
        {
            if(number == 0)
            {
                Console.WriteLine(number);
                return 0;
            }
            else
            {
                Console.WriteLine(number);
                return Count(--number);
            }
        }
    }
}
