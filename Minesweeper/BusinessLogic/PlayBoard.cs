using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BusinessLogic
{
    public class PlayBoard
    {


        private readonly int width;
        private readonly int height;
        private readonly int mineCount;
        private Cell[,] cells;
        private CheckAdjacentCell checkAdjacent;


        public PlayBoard(int width, int height, int mineCount)
        {
            this.width = width;
            this.height = height;
            this.mineCount = mineCount;

            cells = RecreateBoard(width, height, mineCount);

            checkAdjacent = new CheckAdjacentCell(this);
        }



        public void OpenCell(int x, int y)
        {
            cells[x, y].Open();

            checkAdjacent.CheckArray(x, y);
        }

        public void OpenCellOnce(int x, int y)
        {
            cells[x, y].Open();
        }

        public void OpenAllCell()
        {
            foreach (var cell in cells)
            {
                cell.Open();
            }
        }

        public void SetFlag(int x, int y)
        {
            cells[x, y].SetFlag();
        }

        public void RemoveFlag(int x, int y)
        {
            cells[x, y].RemoveFlag();
        }

        //Create Board 
        //Reset 

        public Cell[,] GetCellValues()
        {
            var copyCells = new Cell[width, height];

            foreach (var cell in cells)
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        copyCells[i, j] = cell.Clone();
                    }
                }
            }

            return cells;
        }


        private Cell[,] RecreateBoard(int width, int height, int mine)
        {
            cells = new Cell[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    cells[i, j] = new Cell(CellValue.Zero);
                }
            }

            for (int i = 0; i < mine; i++)
            {
                GetRandomCell();
                if (cells[X, Y].Value != CellValue.Mine)
                {
                    cells[X, Y] = new Cell(CellValue.Mine);
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (cells[i, j].Value != CellValue.Mine)
                    {
                        SetMineCount(i, j);
                    }

                }
            }

            return cells;
        }

        private int X;
        private int Y;

        Random random = new Random();

        private void GetRandomCell()
        {
            X = random.Next(0, height);
            Y = random.Next(0, width);
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
                        if (cells[i, j].Value == CellValue.Mine)
                        {
                            mineCount++;
                            cells[x, y] = new Cell((CellValue)mineCount);
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
        }
    }


}
