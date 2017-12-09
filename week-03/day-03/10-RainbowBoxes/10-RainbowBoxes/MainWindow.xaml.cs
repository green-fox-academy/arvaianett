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

namespace _10_RainbowBoxes
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

            int size = 500;

            for (int i = 0; i < 160; i++)
            {
                Color randomColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));

                size = size - 3;

                Square(foxDraw, size, randomColor);
            }
        }
        public static void Square(FoxDraw foxDraw, int size, Color randomColor)
        {
            int x = (500 - size) / 2;
            int y = (500 - size) / 2;
            foxDraw.FillColor(randomColor);
            foxDraw.DrawRectangle(x, y, size, size);
        }
    }
}