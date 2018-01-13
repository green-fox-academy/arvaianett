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
using RPGGame;

namespace RPGGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FoxDraw FoxDraw;

        public MainWindow()
        {
            InitializeComponent();
            
            var foxDraw = new FoxDraw(canvas);

            var floor = new Floor(canvas);

            floor.AddFloor();

            var hero = new Characters(canvas);

            hero.AddHero();
        }

        private new void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F)
            {
                double x = FoxDraw.GetLeft(FoxDraw.Tiles[0]) + 10;
                double y = FoxDraw.GetTop(FoxDraw.Tiles[0]) + 10;
                FoxDraw.SetPosition(FoxDraw.Tiles[0], x, y);
            }
        }
    }
}
