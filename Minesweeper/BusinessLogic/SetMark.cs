using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class SetMark
    {
        public void Mark(Cell cell)
        {
            if (cell.CellIsOpen == false)
            {
                cell.MarkIsSet = true;
            }
        }

        public void Demark(Cell cell)
        {
            cell.MarkIsSet = false;
        }
    }
}
