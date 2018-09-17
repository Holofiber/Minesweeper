using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Tests
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void Cell_Open_Test()
        {
            Cell cell = new Cell(CellValue.Zero);

            cell.IsOpen.Should().BeFalse();
            cell.Open();
            cell.IsOpen.Should().BeTrue();
        }

        [TestMethod]
        public void Cell_Open_WithFlag_Test()
        {
            Cell cell = new Cell(CellValue.Zero);

            cell.SetFlag();

            cell.IsOpen.Should().BeFalse();
            cell.Open();
            cell.IsOpen.Should().BeFalse();
        }

        [TestMethod]
        public void Cell_SetFlag_Test()
        {
            Cell cell = new Cell(CellValue.Zero);

            cell.IsOpen.Should().BeFalse();

            cell.Flagged.Should().BeFalse();
            cell.SetFlag();
            cell.Flagged.Should().BeTrue();
        }

        [TestMethod]
        public void Cell_SetFlag_WhenOpen_Test()
        {
            Cell cell = new Cell(CellValue.Zero);

            cell.Open();

            cell.Flagged.Should().BeFalse();
            cell.SetFlag();
            cell.Flagged.Should().BeFalse();
        }
    }
}
