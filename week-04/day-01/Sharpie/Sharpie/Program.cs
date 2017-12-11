using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie sharpie1 = new Sharpie();

            sharpie1.color = "blue";
            sharpie1.width = 20;

            sharpie1.Use();

            Console.WriteLine(sharpie1.InkAmount);
            Console.ReadLine();           
        }
    }
}
