using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class PlayField
    {
        public PlayField()
        {
            FieldCells = new Cell[3, 3]
            {
                {new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.Two)},
                {new Cell(CellValue.Mine), new Cell(CellValue.Three), new Cell(CellValue.Mine)},
                {new Cell(CellValue.One), new Cell(CellValue.Two), new Cell(CellValue.One)}
            };
        }

        public Cell[,] FieldCells { get; set; }
    }
}
