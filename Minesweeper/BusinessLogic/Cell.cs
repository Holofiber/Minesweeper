using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Cell
    {
        public Cell(CellValue value)
        {
            Value = value;
        }

        public bool CellIsOpen { get; set; } = false;

        public bool MarkIsSet { get; set; } = false;

        public CellValue Value { get; set; }
    }

    public enum CellValue
    {
        Null = 0,
        One = 1,
        Two = 2,
        Three = 3,
        For = 4,
        Five = 5,
        Sex = 6,
        Seven = 7,
        Eight = 8,

        Mine = 100
    }
}