using System;
using System.Collections.Generic;
using System.Text;

namespace TakeMeToThe
{
    public class Sweets
    {
        public double Price { get; set; }
        public double SugarToMake { get; set; }

        public Sweets(double price, double sugarToMake)
        {
            Price = price;
            SugarToMake = sugarToMake;
        }
    }
}
