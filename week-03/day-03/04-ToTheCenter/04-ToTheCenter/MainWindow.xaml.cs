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

namespace _04_ToTheCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {              
                int pointX = rnd.Next(500);
                
                int pointY = rnd.Next(400);
                Lines(foxDraw, pointX, pointY);
            }
        }
        public static void Lines(FoxDraw foxDraw, int pointX, int pointY)
        {
            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(pointX, pointY);

            var endPoint = new Point(200, 250);
            foxDraw.DrawLine(startPoint, endPoint);

        }
    }
}
