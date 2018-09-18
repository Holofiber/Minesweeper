using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BusinessLogic
{
    public class GenerateBoard
    {
        private int Width;
        private int Height;
        private int X;
        private int Y;
        private Cell[,] arCells;



       /* public Cell[,] Generator(int width, int height, int mine)
        {
            Width = width;
            Height = height;
            arCells = new Cell[width, height];

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

            SetMineCount(Width, height);

            return arCells;
        }

        Random random = new Random();
        private void GetRandomCell()
        {
            X = random.Next(0, Height);
            Y = random.Next(0, Width);
        }

        public void SetMineCount(int x, int y)
        {
            int mineCount = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    try
                    {
                        if (arCells[i, j].Value == CellValue.Mine)
                        {
                            mineCount++;
                            arCells[i, j] = new Cell((CellValue)mineCount);
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        continue;
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e);
                        throw;
                    }
                }
            }
        }*/
    }
}
