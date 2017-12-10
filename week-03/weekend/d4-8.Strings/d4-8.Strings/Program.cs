using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d4_8.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "xxXXYY";

            Console.WriteLine(Remove(letters));
            Console.ReadLine();
        }
        static string Remove(string letters)
        {
            letters = letters.Replace("x", string.Empty);
            return letters;
        }
    }
}
