﻿using System;
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

        public Status Status { get; private set; }

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
            if (x > width || y > height)
            {
                throw new IndexOutOfRangeException();
            }

            cells[x, y].Open();

            UpdateGameStatus();

            checkAdjacent.CheckArray(x, y);
        }

        private void UpdateGameStatus()
        {
            if (Status == Status.Initial)
            {
                Status = Status.Live;
            }

            //check win
            if (CheckWinCondition())
            {
                Status = Status.Win;
            }

            // check loose
            if (CheckLooseCondition())
            {
                Status = Status.Loose;
            }
        }

        private bool CheckLooseCondition()
        {
            foreach (var cell in cells)
            {
                if (cell.IsOpen && cell.Value == CellValue.Mine)
                {
                    return true;
                }

            }

            return false;
        }

        private bool CheckWinCondition()
        {
            foreach (var cell in cells)
            {
                bool cellIsClosed = !cell.IsOpen;
                bool notMine = cell.Value != CellValue.Mine;

                if (cellIsClosed && notMine)
                {
                    return false;
                }
            }
            return true;

        }

        public void OpenCellOnce(int x, int y)
        {
            if (x > width || y > height)
            {
                throw new IndexOutOfRangeException();
            }
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
            if (x > width || y > height)
            {
                throw new IndexOutOfRangeException();
            }
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



            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    copyCells[i, j] = cells[i, j].Clone();
                }
            }


            return copyCells;
        }


        private Cell[,] RecreateBoard(int width, int height, int mine)
        {
            cells = new Cell[width, height];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
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

            int minX = x - 1;
            int maxX = x + 1;
            int minY = y - 1;
            int maxY = y + 1;

            if (x == 0)
            {
                minX = 0;
            }
            if (x == height - 1)
            {
                maxX = height - 1;
            }
            if (y == 0)
            {
                minY = 0;
            }
            if (y == width - 1)
            {
                maxY = width - 1;
            }

            for (int i = minX; i <= maxX; i++)
            {
                for (int j = minY; j <= maxY; j++)
                {
                    try
                    {
                        if (cells[i, j].Value == CellValue.Mine)
                        {
                            mineCount++;
                            cells[x, y] = new Cell((CellValue)mineCount);
                        }
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
