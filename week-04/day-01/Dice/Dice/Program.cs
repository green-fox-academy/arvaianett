using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();

            dice1.Roll();
            Console.WriteLine(dice1.D6);

            Console.WriteLine(dice1.GetCurrent(dice1));

            dice1.Reroll();
            Console.WriteLine(dice1.D6);
           
            Console.WriteLine(dice1.Six(dice1));

            Console.ReadLine();           
        }
    }
}
