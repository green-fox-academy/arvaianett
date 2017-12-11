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

namespace _20_Triangles
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

            int x1 = 225;
            int y1 = 43;
            int x2 = 275;
            int y2 = 43;

            for (int i = 0; i < 4; i++)
            {
                foxDraw.DrawLine(x1, y1, x2, y2);

                x1 -= 25;
                y1 += 43;
                x2 += 25;
                y2 += 43;
            }

            int a1 = 250;
            int b1 = 0;
            int a2 = 150;
            int b2 = 172;

            for (int j = 0; j < 4; j++)
            {
                foxDraw.DrawLine(a1, b1, a2, b2);

                a1 += 25;
                b1 += 43;
                a2 += 50;
            }

            int c1 = 250;
            int d1 = 0;
            int c2 = 350;
            int d2 = 172;

            for (int k = 0; k < 4; k++)
            {
                foxDraw.DrawLine(c1, d1, c2, d2);

                c1 -= 25;
                d1 += 43;
                c2 -= 50;
            }
        }
    }
}
