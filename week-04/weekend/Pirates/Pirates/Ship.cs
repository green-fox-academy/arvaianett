using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    public class Ship
    {
        public const int shipCapacity = 50;

        public List<Pirate> pirateList;
        public Pirate captain;
        public int score;
        public string winBattle;

        Random random = new Random();

        public void FillShip()
        {
            captain = new Pirate();

            pirateList = new List<Pirate>();

            int numberOfCrew = random.Next(shipCapacity + 1);

            for (int i = 0; i < numberOfCrew; i++)
            {
                pirateList.Add(new Pirate());
            }
        }

        public void Print()
        {
            Console.WriteLine("Captain consumed rum: " + captain.drinkLevel);
            Console.WriteLine("Captain's state: " + captain.state);
            Console.WriteLine("Current crew members : " + pirateList);
        }

        public void Battle(Ship otherShip)
        {
            if (otherShip.score > score)
            {
                winBattle = "The other ship win";
            }
            else if (otherShip.score < score)
            {
                winBattle = "This ship win";
            }
            else
            {
                winBattle = "No one win";
            }
        }
    }
}
