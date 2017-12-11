using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        public int D6 { get; set; }

        public static Random random = new Random();

        public void Roll()
        {           
            D6 = random.Next(1, 7);
        }
        public int GetCurrent(Dice current)
        {
            return current.D6;
        }
        public void Reroll()
        {           
            D6 = random.Next(1, 7);
        }
        public bool Six(Dice dice)
        {
            if (dice.D6 == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
