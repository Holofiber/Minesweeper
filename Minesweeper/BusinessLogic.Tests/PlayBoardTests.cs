using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Tests
{
    [TestClass]
    public class PlayBoardTests
    {
        [TestMethod]
        public void CheckWin_Test()
        {
            PlayBoard board = new PlayBoard(3, 3, 1);

            PrivateObject cellsObject = new PrivateObject(board);

            cellsObject.SetField("cells", DataLayer.Get3x3Board());

            board.Status.Should().Be(Status.Initial);

            board.OpenCell(0, 0);
            board.Status.Should().Be(Status.Live);

            board.SetFlag(0, 1);
            board.Status.Should().Be(Status.Live);

            board.OpenCell(0, 2);
            board.Status.Should().Be(Status.Live);

            board.SetFlag(1, 0);
            board.Status.Should().Be(Status.Live);

            board.OpenCell(1, 1);
            board.Status.Should().Be(Status.Live);

            board.SetFlag(1, 2);
            board.Status.Should().Be(Status.Live);

            board.OpenCell(2, 0);
            board.Status.Should().Be(Status.Live);

            board.OpenCell(2, 1);
            board.Status.Should().Be(Status.Live);

            board.OpenCell(2, 2);
            board.Status.Should().Be(Status.Win);
        }

        [TestMethod]
        public void CheckLoose_Test()
        {
            PlayBoard board = new PlayBoard(3, 3, 1);

            PrivateObject cellsObject = new PrivateObject(board);

            cellsObject.SetField("cells", DataLayer.Get3x3Board());

            board.Status.Should().Be(Status.Initial);

            board.OpenCell(0, 0);
            board.Status.Should().Be(Status.Live);

            board.SetFlag(0, 1);
            board.Status.Should().Be(Status.Live);

            board.OpenCell(0, 2);
            board.Status.Should().Be(Status.Live);

            board.OpenCell(1, 0);
            board.Status.Should().Be(Status.Loose);
        }
    }

}
