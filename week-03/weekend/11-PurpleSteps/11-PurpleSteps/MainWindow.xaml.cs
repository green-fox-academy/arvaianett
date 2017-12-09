﻿using System;
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

namespace _11_PurpleSteps
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

            int size = 20;
            int numberOfBoxes = 19;
            int x = 0;
            int y = 0;

            for (int i = 0; i < numberOfBoxes; i++)
            {
                x = x + size;
                y = y + size;
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(x, y, size, size);
            }
        }
    }
}
