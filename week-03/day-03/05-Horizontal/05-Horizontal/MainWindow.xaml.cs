using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace _05_Horizontal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Random rnd = new Random();

            int lineX = 0;
            int lineY = 0;

            for (int i = 0; i < 3; i++)
            {
                lineX = rnd.Next(500);
                lineY = rnd.Next(400);
                Lines(foxDraw, lineX, lineY);
            }
        }
        public static void Lines(FoxDraw foxDraw, int lineX, int lineY)
        {
            var startPoint = new Point(lineX, lineY);
            var endPoint = new Point(lineX + 50, lineY);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
