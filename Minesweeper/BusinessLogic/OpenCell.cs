using System;

namespace BusinessLogic
{
    public class OpenCell
    {

        public void Open(Cell cell)
        {
            if (cell.Value == CellValue.Mine)
            {
                Console.WriteLine("Game Over!");
                GameStatus.GameIsLive = false;
            }
            else
            {
                GameStatus.GameIsLive = true;
                cell.CellIsOpen = true;
                Console.WriteLine("Luck!");

            }
        }
    }
}