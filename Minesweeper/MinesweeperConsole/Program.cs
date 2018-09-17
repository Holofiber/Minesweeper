using System;
using System.Drawing;
using System.Text;
using BusinessLogic;
using Console = Colorful.Console;

namespace MinesweeperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int width = 3;
            int hight = 3;
            int mineCount = 3;

            PlayBoard board = new PlayBoard(width, hight, mineCount);
            //var cellValues = board.GetCellValues();

            var cellValues =new Cell[3, 3]
                {
                    {new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.Two)},
                    {new Cell(CellValue.Mine), new Cell(CellValue.Three), new Cell(CellValue.Mine)},
                    {new Cell(CellValue.One), new Cell(CellValue.Two), new Cell(CellValue.One)}
                };

            for (int i = 0; i < width; i++)
            {

                Console.WriteLine();
                for (int j = 0; j < hight; j++)
                {

                    PrintCellValue(cellValues[i, j]);
                    Console.Write(" ");
                }

                
                
               
            }

            Console.ReadKey();
        }

        static void PrintCellValue(Cell cell)
        {

            var value = cell.Value;
            if (cell.IsOpen == false)
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
                        
                        Console.Write("[ ]");
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
                        Console.Write("*");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }
            }
        }
    }
}
