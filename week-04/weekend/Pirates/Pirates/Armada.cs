using System;
using System.Collections.Generic;
using System.Text;

namespace Pirates
{
    public class Armada
    {
        public const int maxArmada = 10;

        public List<Ship> armada;

        
        public void FillArmada()
        { 
            armada = new List<Ship>();

            for (int i = 0; i < maxArmada; i++)
            {
                armada.Add(new Ship());
            }
        }

        public void War(List<Ship> otherArmada)
        {

        }
    }
}
