using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BusinessLogic
{
    public class CheckAdjacentCell
    {
        private PlayField Field { get; set; }
        private Cell[,] arrayCells;

        public CheckAdjacentCell(PlayField field)
        {
            Field = field;
        }

        public void CheckArray(int x, int y)
        {
            arrayCells = Field.FieldCells;

            var myCell = arrayCells[x, y];

            if (myCell.Value == CellValue.Null)
            {
                forCycle(x, y);
                foreach (var arrayCell in arrayCells)
                {
                    if (arrayCell.CellIsOpen == true)
                    {
                        Debug.WriteLine(arrayCell.Value);
                    }
                }
            }
            else
            {
                return;
            }
        }

        public void forCycle(int x, int y)
        {
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    try
                    {
                        if (arrayCells[i, j].MarkIsSet == false)
                        {
                            arrayCells[i, j].CellIsOpen = true;
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
