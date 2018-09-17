using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BusinessLogic
{
    public class CheckAdjacentCell
    {
        private PlayBoard Board { get; }
        private Cell[,] arrayCells;

        public CheckAdjacentCell(PlayBoard board)
        {
            Board = board;
        }

        public void CheckArray(int x, int y)
        {
           // arrayCells = Board.FieldCells;

            var myCell = arrayCells[x, y];

            if (myCell.Value == CellValue.Zero)
            {
                CheckAdjacentCallCycle(x, y);

                foreach (var arrayCell in arrayCells)
                {
                    if (arrayCell.IsOpen == true)
                    {
                        Debug.WriteLine(arrayCell.Value);
                    }
                }
            }

        }

        public void CheckAdjacentCallCycle(int x, int y)
        {
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    try
                    {
                        if (arrayCells[i, j].Flagged == false)
                        {
                            //  arrayCells[i, j].IsOpen = true;
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
