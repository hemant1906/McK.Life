using System;
using McK.GameOfLife.Model;
using McK.GameOfLife.Model.Cells;
using McK.GameOfLife.Model.Playfields;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McK.GameOfLife.TestCases
{
    [TestClass]
    public class PlayFieldTest
    {
        [TestMethod]
        public void TestCreatePlayfieldInstance()
        {
            ICellFactory factory = new GridCellFactory(4, 4);
            IPlayField playField = new GridPlayField(factory,4, 4);
            Assert.AreEqual(4, playField.Columns);
            Assert.AreEqual(4, playField.Rows);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestMinimumPlayfieldException()
        {
            try
            {
                ICellFactory factory = new GridCellFactory(4, 4);
                new GridPlayField(factory,3, 4);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("rows and columns value can't ne less than 4", exception.Message);
                throw;
            }
        }

        [TestMethod]
        public void TestInitializePlayField()
        {
            ICellFactory factory = new GridCellFactory(4, 4);
            IPlayField playField = new GridPlayField(factory,4, 4);
            playField.InitializePlayField("01001101001");
            AbstractCell[,] cells = playField.GetCells();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Assert.IsNotNull(cells[i, j]);
        }

        [TestMethod]
        public void TestGetCells()
        {
            ICellFactory factory = new GridCellFactory(4, 4);
            IPlayField playField = new GridPlayField(factory,4, 4);
            playField.InitializePlayField("01001101001");
            AbstractCell[,] cells = playField.GetCells();
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
                ICellFactory factory = new GridCellFactory(4, 4);
                IPlayField playField = new GridPlayField(factory,4, 4);
                playField.InitializePlayField("01001101001");
                playField.GetCell(-1, -2);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("row should be between 0 to 3 and column should be between 0 to 3", exception.Message);
                throw;
            }
        }
    }
}