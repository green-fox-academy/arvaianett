using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4_7.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "xxXXxx";

            Console.WriteLine(Change(letters));
            Console.ReadLine();
        }
        static string Change(string letters)
        {
            letters = letters.Replace("x", "y");
            return letters;
        }
    }
}
