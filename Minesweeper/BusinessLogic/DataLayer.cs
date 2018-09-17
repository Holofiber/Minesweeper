using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public static class DataLayer
    {
        public static Cell[,] Get3x3Board()
        {
            return new Cell[3, 3]
            {
                {new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.Two)},
                {new Cell(CellValue.Mine), new Cell(CellValue.Three), new Cell(CellValue.Mine)},
                {new Cell(CellValue.One), new Cell(CellValue.Two), new Cell(CellValue.One)}
            };
        }

        public static Cell[,] Get3x3OpenBoard()
        {
            var cells = new Cell[3, 3]
            {
                {new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.Two)},
                {new Cell(CellValue.Mine), new Cell(CellValue.Three), new Cell(CellValue.Mine)},
                {new Cell(CellValue.One), new Cell(CellValue.Two), new Cell(CellValue.One)}
            };

            foreach (var cell in cells)
            {
                cell.Open();
            }

            return cells;
        }

        public static Cell[,] Get10x10Board()
        {
            return new Cell[10, 10]
            {
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Two), new Cell(CellValue.Mine),new Cell(CellValue.Two),  new Cell(CellValue.One),new Cell(CellValue.Two), new Cell(CellValue.One), new Cell(CellValue.One),    new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Mine),new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.Mine),new Cell(CellValue.Two), new Cell(CellValue.Mine),new Cell(CellValue.One), new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.One), new Cell(CellValue.One), new Cell(CellValue.One), new Cell(CellValue.One),new Cell(CellValue.Two), new Cell(CellValue.One),new Cell(CellValue.One),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.One), new Cell(CellValue.One), new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Mine), new Cell(CellValue.Two), new Cell(CellValue.One), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.Two), new Cell(CellValue.One),new Cell(CellValue.One), new Cell(CellValue.One),new Cell(CellValue.One),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.One), new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.One),new Cell(CellValue.One), new Cell(CellValue.Mine),new Cell(CellValue.One),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.Two),new Cell(CellValue.One), new Cell(CellValue.Two),new Cell(CellValue.Two),  new Cell(CellValue.One)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.One), new Cell(CellValue.Mine), new Cell(CellValue.One),new Cell(CellValue.Zero), new Cell(CellValue.One),new Cell(CellValue.Mine),  new Cell(CellValue.One)}
            };
        }

        public static Cell[,] Get10x10OpenBoard()
        {
            var cells = new Cell[10, 10]
            {
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Two), new Cell(CellValue.Mine),new Cell(CellValue.Two),  new Cell(CellValue.One),new Cell(CellValue.Two), new Cell(CellValue.One), new Cell(CellValue.One),    new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Mine),new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.Mine),new Cell(CellValue.Two), new Cell(CellValue.Mine),new Cell(CellValue.One), new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.One), new Cell(CellValue.One), new Cell(CellValue.One), new Cell(CellValue.One),new Cell(CellValue.Two), new Cell(CellValue.One),new Cell(CellValue.One),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.One), new Cell(CellValue.One), new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Mine), new Cell(CellValue.Two), new Cell(CellValue.One), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.Two), new Cell(CellValue.One),new Cell(CellValue.One), new Cell(CellValue.One),new Cell(CellValue.One),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.One), new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.One),new Cell(CellValue.One), new Cell(CellValue.Mine),new Cell(CellValue.One),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.Two),new Cell(CellValue.One), new Cell(CellValue.Two),new Cell(CellValue.Two),  new Cell(CellValue.One)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.One), new Cell(CellValue.Mine), new Cell(CellValue.One),new Cell(CellValue.Zero), new Cell(CellValue.One),new Cell(CellValue.Mine),  new Cell(CellValue.One)}
            };

            foreach (var cell in cells)
            {
                if (cell.Value == CellValue.Mine)
                {
                    cell.SetFlag();
                }
                else
                {
                    cell.Open();
                }
                
            }

            return cells;
        }

        public static Cell[,] Get10x10PartialyOpenBoard()
        {
            var cells = new Cell[10, 10]
            {
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Two), new Cell(CellValue.Mine),new Cell(CellValue.Two),  new Cell(CellValue.One),new Cell(CellValue.Two), new Cell(CellValue.One), new Cell(CellValue.One),    new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Mine),new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.Mine),new Cell(CellValue.Two), new Cell(CellValue.Mine),new Cell(CellValue.One), new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.One), new Cell(CellValue.One), new Cell(CellValue.One), new Cell(CellValue.One),new Cell(CellValue.Two), new Cell(CellValue.One),new Cell(CellValue.One),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.One), new Cell(CellValue.One), new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Mine), new Cell(CellValue.Two), new Cell(CellValue.One), new Cell(CellValue.Zero),new Cell(CellValue.Zero), new Cell(CellValue.Zero),new Cell(CellValue.Zero),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.One),  new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.Two), new Cell(CellValue.One),new Cell(CellValue.One), new Cell(CellValue.One),new Cell(CellValue.One),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.One), new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.One),new Cell(CellValue.One), new Cell(CellValue.Mine),new Cell(CellValue.One),  new Cell(CellValue.Zero)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.Two),new Cell(CellValue.One), new Cell(CellValue.Two),new Cell(CellValue.Two),  new Cell(CellValue.One)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.One), new Cell(CellValue.Mine), new Cell(CellValue.One),new Cell(CellValue.Zero), new Cell(CellValue.One),new Cell(CellValue.Mine),  new Cell(CellValue.One)}
            };

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (cells[i, j].Value != CellValue.Mine)
                    {
                        cells[i, j].Open();
                    }

                }
            }


            return cells;
        }
    }
}
