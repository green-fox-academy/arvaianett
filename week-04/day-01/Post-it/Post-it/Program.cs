using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_it
{
    class Program
    {
        public struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;
        }
        static void Main(string[] args)
        {
            PostIt postIt1;

            postIt1.BackgroundColor = "";
            postIt1.Text = "";
            postIt1.TextColor = "";
        }
    }
}
