using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RPGGame
{
    public class Characters
    {
        private Canvas canvas;

        public Characters(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void AddHero()
        {
            var foxDraw = new FoxDraw(canvas);

            foxDraw.AddImage("./Assets/hero-down.png", 0, 0);
        }
    }
}
