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

namespace _08_SquarePositioning
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
    
            Random rnd = new Random();

            int pointX = 0;
            int pointY = 0;

            for (int i = 0; i < 3; i++)
            {
                pointX = rnd.Next(500);
                pointY = rnd.Next(400);
                Square(foxDraw, pointX, pointY);           
            }
        }
        public static void Square(FoxDraw foxDraw, int pointX, int pointY)
        {
            foxDraw.DrawRectangle(pointX, pointY, 50, 50);
        }
    }
}
