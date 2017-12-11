using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Sharpie
    {
        public string color;
        public float width;
        public float InkAmount;

        public Sharpie()
        {
            InkAmount = 100;
        }

        public void Use()
        {
            InkAmount -= 1;
        }
    }
}
