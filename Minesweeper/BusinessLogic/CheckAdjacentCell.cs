using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class CheckAdjacentCell
    {
        private PlayBoard Board { get; }
        private Cell[,] arrayCells;

        private HashSet<(int, int)> OpenCells = new HashSet<(int, int)>();
        private List<(int, int)> OpenCells2 = new List<(int, int)>();
        private List<(int, int)> OpenCells3 = new List<(int, int)>();

        public CheckAdjacentCell(PlayBoard board)
        {
            Board = board;
        }

        public void CheckArray(int x, int y)
        {
            arrayCells = Board.GetCellValues();

            var myCell = arrayCells[x, y];

            if (myCell.Value == CellValue.Zero)
            {
                CheckAdjacentCallCycle(x, y);
            }

            if (OpenCells != null)
                OpenCells2.AddRange(OpenCells);

            int beforeCount = OpenCells.Count;
            int afterCount = 0;

            int zzz = 0;


            do
            {
                beforeCount = OpenCells.Count;

                foreach (var openCell in OpenCells2)
                {
                    CheckAdjacentCallCycle(openCell.Item1, openCell.Item2);
                }

                OpenCells2.Clear();
                OpenCells3.Clear();
                OpenCells3.AddRange(OpenCells);

                for (int i = afterCount; i < OpenCells.Count; i++)
                {
                    OpenCells2.Add(OpenCells3[i]);
                }

                zzz++;
                Debug.WriteLine(zzz);

                afterCount = OpenCells.Count;

            } while (beforeCount != afterCount);
        }

        private void CheckAdjacentCallCycle(int x, int y)
        {
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    try
                    {
                        if (arrayCells[i, j].Flagged == false)
                        {
                            Board.OpenCellOnce(i, j);

                            if (arrayCells[i, j].Value == CellValue.Zero)
                            {
                                OpenCells.Add((i, j));
                            }
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
