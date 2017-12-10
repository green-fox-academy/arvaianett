using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.StringsAgainAndAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "salalala";

            Console.WriteLine(Separate(input));
            Console.ReadLine();
        }
        static string Separate(string input)
        {
            if (input.LastIndexOf("*") == input.Length - 2)
            {
                return input;
            }
            else
            {               
                input = input.Insert(input.LastIndexOf("*") + 2, "*" );
                return Separate(input);
            }
        }
    }
}
