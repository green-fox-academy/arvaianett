using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace RPGGame
{
    internal class Floor
    {
        Random randomNumber = new Random();

        private const int FloorMap = 10;
        private const int TileSize = 50;
        private const int AmountOfWallTile = 43;
        private const int TableSize = 500;

        private Canvas canvas;

        public Floor(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void AddFloor()
        {
            var foxDraw = new FoxDraw(canvas);

            int coordinateX = 0;
            int coordinateY = 0;

            bool[,] FloorMap = new bool[10, 10] { { true, true, false, false, true, false, false, true, false, true},
                                                  { true, true, false, false, true, false, true, true, true, true},
                                                  { true, true, true, true, true, true, true, true, false, true},
                                                  { false, true, false, false, true, false, true, true, false, true},
                                                  { false, true, true, false, true, false, true, true, false, true},
                                                  { true, true, false, false, true, false, true, true, true, true},
                                                  { false, true, false, false, true, false, true, false, false, true},
                                                  { true, true, true, true, true, false, true, false, false, true},
                                                  { true, true, false, false, true, false, true, true, true, true},
                                                  { false, false, false, false, true, false, true, true, false, false}};

            for (int i = 0; i < 10; i++)
            {               
                for (int j = 0; j < 10; j++)
                {
                    if (FloorMap[i, j] == true)
                    {
                        foxDraw.AddImage("./Assets/floor.png", coordinateX, coordinateY);
                    }
                    else
                    {
                        foxDraw.AddImage("./Assets/wall.png", coordinateX, coordinateY);
                    }
                    coordinateX += TileSize;
                }
                coordinateX = 0;
                coordinateY += TileSize;
            }
        }
    }
}