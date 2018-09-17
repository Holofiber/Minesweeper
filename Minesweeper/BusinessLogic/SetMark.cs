using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class SetMark
    {
        public void Mark(Cell cell)
        {
            if (cell.IsOpen == false)
            {
                // cell.Flagged = true;
            }
        }

        public void Demark(Cell cell)
        {
            // cell.Flagged = false;
        }
    }
}
