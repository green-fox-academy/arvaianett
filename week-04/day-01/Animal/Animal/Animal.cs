using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public int hunger;
        public int thirst;

        public void Eat()
        {
            hunger -= 1;
        }
        public void Drink()
        {
            thirst -= 1;
        }
        public void Play()
        {
            hunger += 1;
            thirst += 1;
        }
    }
}
