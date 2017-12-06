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

namespace _01_MiddleLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRedLines(foxDraw);
            DrawGreenLines(foxDraw);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.
        }
        public static void DrawRedLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 200, 500, 200);
        }
        public static void DrawGreenLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(250, 0, 250, 500);
        }
    }
}
