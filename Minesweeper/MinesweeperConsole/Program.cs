using System;
using System.Drawing;
using System.Text;
using BusinessLogic;
using Console = Colorful.Console;

namespace MinesweeperConsole
{
    class Program
    {
        private static string Command;
        private static Cell[,] Cells;
        private static int width = 100;
        private static int hight = 100;

        static void Main(string[] args)
        {


            int mineCount = 300;

            PlayBoard board = new PlayBoard(width, hight, mineCount);
            var cellValues = board.GetCellValues();

          //  var cellValues = DataLayer.Get10x10Board();

            Cells = cellValues;



            PrintBoard(Cells);
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
                    Command = Console.ReadLine();
                    var commandParameters = Command.Split(' ');
                    if (commandParameters[0] == "OpenAll")
                    {
                        foreach (var cell in Cells)
                        {
                            cell.Open();
                        }
                    }


                    if (commandParameters.Length == 3)
                    {
                        int x;
                        Int32.TryParse(commandParameters[1], out x);

                        int y;
                        Int32.TryParse(commandParameters[2], out y);

                        switch (commandParameters[0])
                        {
                            case "Open":
                                Cells[x, y].Open();
                                break;
                            case "SetFlag":
                                Cells[x, y].SetFlag();
                                break;
                            case "RemoveFlag":
                                Cells[x, y].RemoveFlag();
                                break;
                            default:
                                System.Console.WriteLine($"Unknown command: {commandParameters[0]}");
                                break;
                        }
                    }


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
            System.Console.WriteLine();
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
