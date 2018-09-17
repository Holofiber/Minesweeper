using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Tests
{
    [TestClass]
    public class SetMark_Tests
    {
        private readonly Cell[,] fieldCells = new Cell[3, 3]
        {
            {new Cell(CellValue.Two), new Cell(CellValue.Mine), new Cell(CellValue.Two)},
            {new Cell(CellValue.Mine), new Cell(CellValue.Three), new Cell(CellValue.Mine)},
            {new Cell(CellValue.One), new Cell(CellValue.Two), new Cell(CellValue.One)}
        };

        [TestMethod]
        public void SetMark_InClosedCell_Test()
        {
            SetMark setMark = new SetMark();

            fieldCells[0, 0].Flagged.Should().BeFalse();

            setMark.Mark(fieldCells[0, 0]);

            fieldCells[0, 0].Flagged.Should().BeTrue();
        }

       /* [TestMethod]
        public void SetMark_InOpenCell_Test()
        {
            SetMark setMark = new SetMark();
            var fiel = new PlayBoard();
            var openCell = new OpenCell();

            fieldCells[0, 0].Flagged.Should().BeFalse();

            openCell.Open(fieldCells[0, 0]);
            setMark.Mark(fieldCells[0, 0]);

            fieldCells[0, 0].Flagged.Should().BeFalse();
        }

        [TestMethod]
        public void DeMark_InClosedCell_Test()
        {
            SetMark setMark = new SetMark();
            var fiel = new PlayBoard();
            fieldCells[0, 0].Flagged.Should().BeFalse();

            setMark.Mark(fieldCells[0, 0]);

            fieldCells[0, 0].Flagged.Should().BeTrue();

            setMark.Demark(fieldCells[0, 0]);

            fieldCells[0, 0].Flagged.Should().BeFalse();
        }*/
    }
}