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

namespace _13_Checkerboard
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

            int length = 8;
            int size = 50;
            int x = 0;
            int y = 0;

            for (int i = 0; i < length; i++)
            {
                x = 0;
                y += size;
                if (i % 2 != 0)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (j % 2 != 0)
                        {
                            foxDraw.StrokeColor(Colors.Black);
                            foxDraw.FillColor(Colors.White);
                            foxDraw.DrawRectangle(x, y, size, size);
                            x += size;
                        }
                        else
                        {
                            foxDraw.StrokeColor(Colors.Black);
                            foxDraw.FillColor(Colors.Black);
                            foxDraw.DrawRectangle(x, y, size, size);
                            x += size;
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < length; k++)
                    {
                        if (k % 2 == 0)
                        {
                            foxDraw.StrokeColor(Colors.Black);
                            foxDraw.FillColor(Colors.White);
                            foxDraw.DrawRectangle(x, y, size, size);
                            x += size;
                        }
                        else
                        {
                            foxDraw.StrokeColor(Colors.Black);
                            foxDraw.FillColor(Colors.Black);
                            foxDraw.DrawRectangle(x, y, size, size);
                            x += size;
                        }
                    }
                }

            }
        }
    }
}
