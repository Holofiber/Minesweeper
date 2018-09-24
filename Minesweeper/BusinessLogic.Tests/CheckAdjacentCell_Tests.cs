using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Tests
{
    [TestClass]
    public class CheckAdjacentCell_Tests
    {
       /* [TestMethod]
        public void OpenAdjancentCell_Test()
        {
            PlayBoard board = new PlayBoard(3,3,3);
            OpenCell openCell = new OpenCell();
            board.FieldCells = new Cell[3, 3]
                {
                    {new Cell(CellValue.Mine), new Cell(CellValue.Mine), new Cell(CellValue.One)},
                    {new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.One)},
                    {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero)}
                };

            CheckAdjacentCell adjacentCell = new CheckAdjacentCell(board);
            board.FieldCells[0, 0].IsOpen.Should().BeFalse();
            board.FieldCells[0, 1].IsOpen.Should().BeFalse();
            board.FieldCells[0, 2].IsOpen.Should().BeFalse();
            board.FieldCells[1, 0].IsOpen.Should().BeFalse();
            board.FieldCells[1, 1].IsOpen.Should().BeFalse();
            board.FieldCells[1, 2].IsOpen.Should().BeFalse();
            board.FieldCells[2, 0].IsOpen.Should().BeFalse();
            board.FieldCells[2, 1].IsOpen.Should().BeFalse();
            board.FieldCells[2, 2].IsOpen.Should().BeFalse();

            //  board.FieldCells[2, 2].IsOpen = true;

            adjacentCell.CheckArray(2, 2);

            board.FieldCells[0, 0].IsOpen.Should().BeFalse();
            board.FieldCells[0, 1].IsOpen.Should().BeFalse();
            board.FieldCells[0, 2].IsOpen.Should().BeFalse();
            board.FieldCells[1, 0].IsOpen.Should().BeFalse();
            board.FieldCells[1, 1].IsOpen.Should().BeTrue();
            board.FieldCells[1, 2].IsOpen.Should().BeTrue();
            board.FieldCells[2, 0].IsOpen.Should().BeFalse();
            board.FieldCells[2, 1].IsOpen.Should().BeTrue();
            board.FieldCells[2, 2].IsOpen.Should().BeTrue();
        }

        [TestMethod]
        public void OpenAdjancentCell_WithMark_Test()
        {
            PlayBoard board = new PlayBoard();
            OpenCell openCell = new OpenCell();
            board.FieldCells = new Cell[3, 3]
            {
                {new Cell(CellValue.Mine), new Cell(CellValue.Mine), new Cell(CellValue.One)},
                {new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.One)},
                {new Cell(CellValue.Zero), new Cell(CellValue.Zero), new Cell(CellValue.Zero)}
            };

            CheckAdjacentCell adjacentCell = new CheckAdjacentCell(board);
            board.FieldCells[0, 0].IsOpen.Should().BeFalse();
            board.FieldCells[0, 1].IsOpen.Should().BeFalse();
            board.FieldCells[0, 2].IsOpen.Should().BeFalse();
            board.FieldCells[1, 0].IsOpen.Should().BeFalse();
            board.FieldCells[1, 1].IsOpen.Should().BeFalse();
            board.FieldCells[1, 2].IsOpen.Should().BeFalse();
            board.FieldCells[2, 0].IsOpen.Should().BeFalse();
            board.FieldCells[2, 1].IsOpen.Should().BeFalse();
            board.FieldCells[2, 2].IsOpen.Should().BeFalse();

            //   board.FieldCells[1, 2].Flagged = true;
            //   board.FieldCells[2, 2].IsOpen = true;

            adjacentCell.CheckArray(2, 2);

            board.FieldCells[0, 0].IsOpen.Should().BeFalse();
            board.FieldCells[0, 1].IsOpen.Should().BeFalse();
            board.FieldCells[0, 2].IsOpen.Should().BeFalse();
            board.FieldCells[1, 0].IsOpen.Should().BeFalse();
            board.FieldCells[1, 1].IsOpen.Should().BeTrue();
            board.FieldCells[1, 2].IsOpen.Should().BeFalse();
            board.FieldCells[2, 0].IsOpen.Should().BeFalse();
            board.FieldCells[2, 1].IsOpen.Should().BeTrue();
            board.FieldCells[2, 2].IsOpen.Should().BeTrue();
        }*/
    }
}
