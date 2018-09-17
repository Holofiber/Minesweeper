using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Tests
{
    [TestClass]
    public class OpenCellTests
    {
        private readonly Cell[,] fieldCells = new Cell[3, 3]
        {
            {new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.Two)},
            {new Cell(CellValue.Mine), new Cell(CellValue.Three), new Cell(CellValue.Mine)},
            {new Cell(CellValue.One), new Cell(CellValue.Two), new Cell(CellValue.One)}
        };

       /* [TestMethod]
        public void OpenCell_Test()
        {
            var fiel = new PlayBoard();

            fieldCells[0, 0].IsOpen.Should().BeFalse();
            OpenCell openCell = new OpenCell();

            openCell.Open(fieldCells[0, 0]);

            fieldCells[0, 0].IsOpen.Should().BeTrue();
        }

        [TestMethod]
        public void OpenCell_WithMine_Test()
        {
            var fiel = new PlayBoard();

            OpenCell openCell = new OpenCell();

            openCell.Open(fieldCells[0, 1]);

            GameStatus.GameIsLive.Should().BeFalse();
        }

        [TestMethod]
        public void OpenCell_WithOutMine_Test()
        {
            var fiel = new PlayBoard();

            OpenCell openCell = new OpenCell();

            openCell.Open(fieldCells[2, 2]);

            GameStatus.GameIsLive.Should().BeTrue();
        }*/


    }
}
