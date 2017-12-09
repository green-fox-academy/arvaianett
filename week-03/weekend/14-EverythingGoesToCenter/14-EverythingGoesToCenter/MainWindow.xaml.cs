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

namespace _14_EverythingGoesToCenter
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

            int x = 0;
            int y = 0;
            int canvasSize = 500;

            CenterLines(foxDraw, x, y, canvasSize);

        }
        static void CenterLines(FoxDraw foxDraw, int x, int y, int canvasSize)
        { 
            foxDraw.StrokeColor(Colors.Green);

            int center = canvasSize / 2;
 
            var endPoint = new Point(center, center);

            int startPoints = 20;

            for (int i = 0; i < canvasSize / startPoints; i++)
            {
                foxDraw.DrawLine(x, y, center, center);
                x += startPoints;
            }
            for (int j = 0; j < canvasSize / startPoints; j++)
            {
                foxDraw.DrawLine(x, y, center, center);
                y += startPoints;
            }
            for (int k = 0; k < canvasSize / startPoints; k++)
            {
                foxDraw.DrawLine(x, y, center, center);
                x -= startPoints;
            }
            for (int l = 0; l < canvasSize / startPoints; l++)
            {
                foxDraw.DrawLine(x, y, center, center);
                y -= startPoints;
            }
        }
    }
}
