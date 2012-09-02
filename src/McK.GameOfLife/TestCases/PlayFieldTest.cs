using System;
using McK.GameOfLife.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McK.GameOfLife.TestCases
{
    [TestClass]
    public class PlayFieldTest
    {
        [TestMethod]
        public void TestCreatePlayfieldInstance()
        {
            IPlayField playField = new PlayFieldGrid(4, 4);
            Assert.AreEqual(4, playField.Width);
            Assert.AreEqual(4, playField.Height);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestMinimumPlayfieldException()
        {
            try
            {
                new PlayFieldGrid(3, 4);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("gridX and gridY value can't ne less than 4", exception.Message);
                throw;
            }
        }

        [TestMethod]
        public void TestInitializePlayField()
        {
            IPlayField playField = new PlayFieldGrid(4, 4);
            playField.InitializePlayField("01001101001");
            Cell[,] cells = playField.GetCells();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Assert.IsNotNull(cells[i, j]);
        }

        [TestMethod]
        public void TestGetCells()
        {
            IPlayField playField = new PlayFieldGrid(4, 4);
            playField.InitializePlayField("01001101001");
            Cell[,] cells = playField.GetCells();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Assert.AreEqual(cells[i, j], playField.GetCell(i, j));
        }

        [TestMethod]
        [ExpectedException(typeof (IndexOutOfRangeException))]
        public void TestInvalidGetCell()
        {
            try
            {
                IPlayField playField = new PlayFieldGrid(4, 4);
                playField.InitializePlayField("01001101001");
                playField.GetCell(-1, -2);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("x should be between 0 to 3 and y should be between 0 to 3", exception.Message);
                throw;
            }
        }
    }
}