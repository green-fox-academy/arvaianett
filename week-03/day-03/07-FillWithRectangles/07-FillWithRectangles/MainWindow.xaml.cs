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

namespace _07_FillWithRectangles
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

            foxDraw.StrokeColor(Colors.DarkSeaGreen);
            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawRectangle(10, 10, 150, 50);

            foxDraw.StrokeColor(Colors.Beige);
            foxDraw.FillColor(Colors.Gold);
            foxDraw.DrawRectangle(20, 10, 100, 60);

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.OldLace);
            foxDraw.DrawRectangle(100, 100, 150, 90);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.FillColor(Colors.Salmon);
            foxDraw.DrawRectangle(120, 170, 10, 50);
        }
    }
}
