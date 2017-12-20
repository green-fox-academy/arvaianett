using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    public class Flowers : Plants
    {
        public Flowers(string color, double currentWaterAmount) : base (color, currentWaterAmount)
        {
            this.color = color;
            this.currentWaterAmount = currentWaterAmount;
        }
    }
}
