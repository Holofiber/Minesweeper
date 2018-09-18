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

        public bool IsOpen { get; private set; }

        public bool Flagged { get; private set; }

        public CellValue Value { get; }

        public void Open()
        {
            if (Flagged)
            {
                return;
            }

            IsOpen = true;
        }

        public void SetFlag()
        {
            if (IsOpen)
            {
                return;
            }

            Flagged = true;
        }

        public void RemoveFlag()
        {
            if (Flagged)
            {
                Flagged = false;
            }
        }

        public Cell Clone()
        {
            return (Cell)MemberwiseClone();
        }
        
    }

    public enum CellValue
    {
        Zero = 0,
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