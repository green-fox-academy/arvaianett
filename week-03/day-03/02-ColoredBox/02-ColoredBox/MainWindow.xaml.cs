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

namespace _02_ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Rectangle(foxDraw);
        }
        public static void Rectangle(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 10, 100, 10);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 10, 0, 150);

            foxDraw.StrokeColor(Colors.Indigo);
            foxDraw.DrawLine(0, 150, 100, 150);

            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(100, 150, 100, 10);
        }
    }
}
