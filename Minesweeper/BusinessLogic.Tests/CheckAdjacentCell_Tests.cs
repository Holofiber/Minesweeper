using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Tests
{
    [TestClass]
    public class CheckAdjacentCell_Tests
    {
        [TestMethod]
        public void OpenAdjancentCell_Test()
        {
            PlayField field = new PlayField();
            OpenCell openCell = new OpenCell();
            field.FieldCells = new Cell[3, 3]
                {
                    {new Cell(CellValue.Mine), new Cell(CellValue.Mine), new Cell(CellValue.One)},
                    {new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.One)},
                    {new Cell(CellValue.Null), new Cell(CellValue.Null), new Cell(CellValue.Null)}
                };

            CheckAdjacentCell adjacentCell = new CheckAdjacentCell(field);
            field.FieldCells[0, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[0, 1].CellIsOpen.Should().BeFalse();
            field.FieldCells[0, 2].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 1].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 2].CellIsOpen.Should().BeFalse();
            field.FieldCells[2, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[2, 1].CellIsOpen.Should().BeFalse();
            field.FieldCells[2, 2].CellIsOpen.Should().BeFalse();

            field.FieldCells[2, 2].CellIsOpen = true;

            adjacentCell.CheckArray(2, 2);

            field.FieldCells[0, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[0, 1].CellIsOpen.Should().BeFalse();
            field.FieldCells[0, 2].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 1].CellIsOpen.Should().BeTrue();
            field.FieldCells[1, 2].CellIsOpen.Should().BeTrue();
            field.FieldCells[2, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[2, 1].CellIsOpen.Should().BeTrue();
            field.FieldCells[2, 2].CellIsOpen.Should().BeTrue();
        }

        [TestMethod]
        public void OpenAdjancentCell_WithMark_Test()
        {
            PlayField field = new PlayField();
            OpenCell openCell = new OpenCell();
            field.FieldCells = new Cell[3, 3]
            {
                {new Cell(CellValue.Mine), new Cell(CellValue.Mine), new Cell(CellValue.One)},
                {new Cell(CellValue.Two), new Cell(CellValue.Two), new Cell(CellValue.One)},
                {new Cell(CellValue.Null), new Cell(CellValue.Null), new Cell(CellValue.Null)}
            };

            CheckAdjacentCell adjacentCell = new CheckAdjacentCell(field);
            field.FieldCells[0, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[0, 1].CellIsOpen.Should().BeFalse();
            field.FieldCells[0, 2].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 1].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 2].CellIsOpen.Should().BeFalse();
            field.FieldCells[2, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[2, 1].CellIsOpen.Should().BeFalse();
            field.FieldCells[2, 2].CellIsOpen.Should().BeFalse();

            field.FieldCells[1, 2].MarkIsSet = true;
            field.FieldCells[2, 2].CellIsOpen = true;

            adjacentCell.CheckArray(2, 2);

            field.FieldCells[0, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[0, 1].CellIsOpen.Should().BeFalse();
            field.FieldCells[0, 2].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[1, 1].CellIsOpen.Should().BeTrue();
            field.FieldCells[1, 2].CellIsOpen.Should().BeFalse();
            field.FieldCells[2, 0].CellIsOpen.Should().BeFalse();
            field.FieldCells[2, 1].CellIsOpen.Should().BeTrue();
            field.FieldCells[2, 2].CellIsOpen.Should().BeTrue();
        }
    }
}
