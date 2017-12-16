using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class AnimalClass
    {
        public int hunger;
        public int thirst;

        public AnimalClass()
        {
            hunger = 50;
            thirst = 50;
        }

        public int Eat(int howManyTimesTheyEat)
        {
            return hunger -= howManyTimesTheyEat;
        }
        public int Drink(int howManyTimesTheyDrink)
        {
            return thirst -= howManyTimesTheyDrink;
        }
        public int PlayHunger(int howManyTimesTheyPlay)
        {
            return hunger += howManyTimesTheyPlay;
        }
        public int PlayThirst(int howManyTimesTheyPlay)
        {
            return thirst += howManyTimesTheyPlay;
        }
    }
}
