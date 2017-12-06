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

namespace _09_CenteredBoxes
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

            double size = 0;

            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                size = rnd.Next(300);
                Square(foxDraw, size);
            }

        }
        public static void Square(FoxDraw foxDraw, double size)
        {
            double x = (500 - size) / 2;
            double y = (300 - size) / 2;

            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}
