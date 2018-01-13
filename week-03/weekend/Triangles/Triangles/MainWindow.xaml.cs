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

namespace Triangles
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

            int startX = 250;
            int startY = 0;
            int side = 50;
            int down = 43;
            int bottom = 25;
            int row = 17;

            //horizontal lines
            int horizontalStartX = startX - row * bottom;
            int horizontalStartY = down * row;
            int horizontalEndX = startX + row * bottom;
            int horizontalEndY = down * row;          

            for (int i = 0; i < row; i++)
            {
                foxDraw.DrawLine(horizontalStartX, horizontalStartY, horizontalEndX, horizontalEndY);

                horizontalStartX += bottom;
                horizontalStartY -= down;
                horizontalEndX -= bottom;
                horizontalEndY -= down;
            }

            //top to left lines
            int leftStartX = startX;
            int leftStartY = startY;
            int leftEndX = startX - bottom * row;
            int leftEndY = down * row;

            for (int j = 0; j < row; j++)
            {
                foxDraw.DrawLine(leftStartX, leftStartY, leftEndX, leftEndY);

                leftStartX += bottom;
                leftStartY += down;
                leftEndX += side;
            }

            //top to right lines
            int rightStartX = startX;
            int rightStartY = startY;
            int rightEndX = startX + bottom * row;
            int rightEndY = down * row;

            for (int k = 0; k < row; k++)
            {
                foxDraw.DrawLine(rightStartX, rightStartY, rightEndX, rightEndY);

                rightStartX -= bottom;
                rightStartY += down;
                rightEndX -= side;
            }
        }
    }
}
