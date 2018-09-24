using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Console = Colorful.Console;

namespace MinesweeperConsole
{
    public class ConsoleOutputService
    {
        GameSingleton singleton = GameSingleton.Instance;


        private void PrintBoard()
        {
            Cell[,] cellValues = singleton.Board.GetCellValues();

            int width = cellValues.GetLength(0);
            int hight = cellValues.GetLength(1);


            for (int i = 0; i < width; i++)
            {
                Colorful.Console.WriteLine();
                for (int j = 0; j < hight; j++)
                {
                    PrintCellValue(cellValues[i, j]);
                    Colorful.Console.Write("|");
                }
            }
        }

        public void UpdateConsole()
        {
            Console.Clear();



            PrintBoard();
            System.Console.WriteLine();
            System.Console.WriteLine("\t Valid Command: [Open X Y] [OpenAll] [SetFlag X Y] [RemoveFlag X Y]");
        }

        static void PrintCellValue(Cell cell)
        {

            var value = cell.Value;
            if (cell.IsOpen == false && cell.Flagged == false)
            {

                Console.Write("#");
            }
            else if (cell.Flagged)
            {
                Console.Write("f");
            }
            else
            {
                switch (value)
                {
                    case CellValue.Zero:
                        Console.BackgroundColor = Color.DarkGray;
                        Console.Write("0");
                        Console.ResetColor();

                        break;
                    case CellValue.One:
                        Console.Write("1", Color.Blue);
                        Console.ResetColor();
                        break;
                    case CellValue.Two:
                        Console.Write("2", Color.Green);
                        Console.ResetColor();
                        break;
                    case CellValue.Three:
                        Console.Write("3", Color.Red);
                        Console.ResetColor();
                        break;
                    case CellValue.For:
                        Console.Write("4", Color.DarkBlue);
                        Console.ResetColor();
                        break;
                    case CellValue.Five:
                        Console.Write("5", Color.Brown);
                        Console.ResetColor();
                        break;
                    case CellValue.Sex:
                        Console.Write("6", Color.Aqua);
                        Console.ResetColor();
                        break;
                    case CellValue.Seven:
                        Console.Write("7", Color.DarkRed);
                        Console.ResetColor();
                        break;
                    case CellValue.Eight:
                        Console.Write("8", Color.Black);
                        Console.ResetColor();
                        break;
                    case CellValue.Mine:
                        Console.BackgroundColor = Color.Red;
                        Console.Write("*");
                        Console.ResetColor();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }
            }
        }
    }
}
