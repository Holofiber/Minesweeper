using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Tests
{
    [TestClass]
    public class CreatePlayFieldTest
    {
        [TestMethod]
        public void PlayField_IsNotNull_Test()
        {
            PlayField playField = new PlayField();
            playField.FieldCells.Should().HaveCount(9);
        }
        [TestMethod]
        public void Test()
        {
            GenerateField g = new GenerateField();

            Cell[,] c = g.Generator(10, 10, 10);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Debug.WriteLine(c[i, j].Value.ToString());
                }
            }
        }
    }
}
