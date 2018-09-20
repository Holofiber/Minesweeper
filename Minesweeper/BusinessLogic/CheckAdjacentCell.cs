using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace BusinessLogic
{
    public class CheckAdjacentCell
    {
        private PlayBoard Board { get; }
        private Cell[,] arrayCells;
        private readonly int boardWidth;
        private readonly int boardHeight;

        private readonly HashSet<Point> openCells = new HashSet<Point>();

        public CheckAdjacentCell(PlayBoard board)
        {
            Board = board;

            boardHeight = board.GetCellValues().GetLength(0);
            boardWidth = board.GetCellValues().GetLength(1);
        }

        public void CheckArray(int x, int y)
        {
            List<Point> OpenCells2 = new List<Point>();


            arrayCells = Board.GetCellValues();

            var myCell = arrayCells[x, y];

            if (myCell.Value == CellValue.Zero)
            {
                CheckAdjacentCallCycle(x, y);
            }

            if (openCells != null)
            {
                OpenCells2.AddRange(openCells);
            }

            void CheckingEmptyArea()
            {
                List<Point> listForCurrenCycle = new List<Point>();

                int afterCount = 0;
                int beforeCount;

                do
                {
                    List<Point> listForTempData = new List<Point>();

                    beforeCount = openCells.Count;

                    foreach (var openCell in listForCurrenCycle)
                    {
                        CheckAdjacentCallCycle(openCell.X, openCell.Y);
                    }

                    listForCurrenCycle.Clear();
                    listForTempData.Clear();

                    listForTempData.AddRange(openCells);

                    for (int i = afterCount; i < openCells.Count; i++)
                    {
                        listForCurrenCycle.Add(listForTempData[i]);
                    }

                    afterCount = openCells.Count;

                } while (beforeCount != afterCount);
            }

            CheckingEmptyArea();
        }

        private void CheckAdjacentCallCycle(int x, int y)
        {
            CheckingAdjacent(x, y);
        }

        private void CheckingAdjacent(int x, int y)
        {
            int minX = x - 1;
            int maxX = x + 1;
            int minY = y - 1;
            int maxY = y + 1;

            if (x == 0)
            {
                minX = 1;
            }
            if (x == boardHeight)
            {
                maxY = boardHeight - 1;
            }
            if (y == 0)
            {
                minY = 1;
            }
            if (y == boardWidth)
            {
                maxY = boardWidth - 1;
            }


            for (int i = minX; i < maxX; i++)
            {
                for (int j = minY; j < maxY; j++)
                {
                    CheckingFlag(i, j);
                }
            }

        }

        private void CheckingFlag(int i, int j)
        {
            try
            {
                if (arrayCells[i, j].Flagged == false)
                {
                    Board.OpenCellOnce(i, j);

                    OpenWhenValueZero(i, j);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        private void OpenWhenValueZero(int i, int j)
        {
            if (arrayCells[i, j].Value == CellValue.Zero)
            {
                openCells.Add(new Point(i, j));
            }
        }
    }
}
