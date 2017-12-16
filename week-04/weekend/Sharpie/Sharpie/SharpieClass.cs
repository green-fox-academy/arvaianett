using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    public class SharpieClass
    {
        public string color;
        public float width;
        public float InkAmount;

        public SharpieClass()
        {
            InkAmount = 100;
        }

        public float Use(float howManyTimes)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                InkAmount -= 1;
            }

            return InkAmount;
        }
    }
}
