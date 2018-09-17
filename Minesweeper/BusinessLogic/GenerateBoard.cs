using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class GenerateBoard
    {
        private int Width;
        private int Height;
        private int X;
        private int Y;



        public Cell[,] Generator(int width, int height, int mine)
        {
            Width = width;
            Height = height;
            Cell[,] arCells = new Cell[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    arCells[i, j] = new Cell(CellValue.Zero);
                }
            }

            for (int i = 0; i < mine; i++)
            {
                GetRandomCell();
                if (arCells[X, Y].Value != CellValue.Mine)
                {
                    arCells[X, Y] = new Cell(CellValue.Mine);
                }
                else
                {
                    i--;
                }

            }

            return arCells;
        }

        Random random = new Random();
        private void GetRandomCell()
        {
            X = random.Next(0, Height);
            Y = random.Next(0, Width);
        }
    }
}
