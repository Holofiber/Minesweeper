using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class PlayBoard
    {
        private readonly int width;
        private readonly int height;
        private readonly int mineCount;
        private readonly Cell[,] plaBoard;

        public PlayBoard(int width, int height, int mineCount)
        {
            this.width = width;
            this.height = height;
            this.mineCount = mineCount;

            plaBoard = RecreateBoard(width, height, mineCount);
        }

        //Create Board 
        //Reset 

        public Cell[,] GetCellValues()
        {
            return plaBoard;
        }


        private Cell[,] RecreateBoard(int width, int height, int mine)
        {
            Cell[,] arCells = new Cell[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    arCells[i, j] = new Cell(CellValue.Zero);
                }
            }

            for (int i = 0; i < mine; i++)
            {
                GetRandomCell();
                if (arCells[X, Y].Value != CellValue.Mine)
                {
                      arCells[X, Y] = new Cell(CellValue.Mine);
                }
                else
                {
                    i--;
                }
            }

            return arCells;
        }

        private int X;
        private int Y;

        Random random = new Random();

        private void GetRandomCell()
        {
            X = random.Next(0, height);
            Y = random.Next(0, width);
        }
    }


}
