using System;
using System.Drawing;
using System.Text;
using BusinessLogic;
using NClap.Repl;
using Console = Colorful.Console;

namespace MinesweeperConsole
{
    class Program
    {
        private static string Command;
        private static Cell[,] Cells;
        private static int width = 10;
        private static int hight = 10;

        static void Main(string[] args)
        {
            GameSingelton singelton = GameSingelton.Instance(width, hight, 10);

            Cells = singelton.Cells;

            UpdateConsole();
            System.Console.WriteLine();

            GameLoop();

            Console.ReadKey();
        }

        private static void GameLoop()
        {
            while (true)
            {
                try
                {
                    var loop = new Loop(typeof(MyCommand));

                    loop.ExecuteOnce();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                    throw;
                }

                UpdateConsole();
            }
        }

        private static void PrintBoard(Cell[,] cellValues)
        {
            for (int i = 0; i < width; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < hight; j++)
                {
                    PrintCellValue(cellValues[i, j]);
                    Console.Write("|");
                }


            }
        }

        private static void UpdateConsole()
        {
            Console.Clear();

            PrintBoard(Cells);

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
                        break;
                    case CellValue.Two:
                        Console.Write("2", Color.Green);
                        break;
                    case CellValue.Three:
                        Console.Write("3", Color.Red);
                        break;
                    case CellValue.For:
                        Console.Write("4", Color.DarkBlue);
                        break;
                    case CellValue.Five:
                        Console.Write("5", Color.Brown);
                        break;
                    case CellValue.Sex:
                        Console.Write("6", Color.Aqua);
                        break;
                    case CellValue.Seven:
                        Console.Write("7", Color.DarkRed);
                        break;
                    case CellValue.Eight:
                        Console.Write("8", Color.Black);
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
