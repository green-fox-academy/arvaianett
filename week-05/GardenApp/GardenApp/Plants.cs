using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    public class Plants : Garden
    {
        public string Type { get; set; }
        public double WaterAbsorb { get; set; }
        public double WhenItNeedsMore { get; set; }

        public string color;
        public double currentWaterAmount;

        public Plants(string color, double currentWaterAmount)
        {
            this.color = color;
            this.currentWaterAmount = currentWaterAmount;
        }
    }
}
