using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    public class Pirate
    {
        public int drinkLevel;
        public string state;

        Random random = new Random();

        public void DrinkSomeRum()
        {
            if (state == "dead")
            {
                Console.WriteLine("he's dead");
            }
            else
            {
                drinkLevel++;
            }
        }

        public void HowItGoingMate()
        {
            if (state == "dead")
            {
                Console.WriteLine("he's dead");
            }
            else if (drinkLevel < 5)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
            }
        }

        public void Die()
        {
            state = "dead";
        }

        public void Brawl(Pirate anotherPirate)
        {
            int randomNumber = random.Next(4);

            if (randomNumber == 1)
            {
                state = "dead";
            }
            else if (randomNumber == 2)
            {
                anotherPirate.state = "dead";
            }
            else
            {
                state = "pass out";
                anotherPirate.state = "pass out";
            }
        }
    }
}
