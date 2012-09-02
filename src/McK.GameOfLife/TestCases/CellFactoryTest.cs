using System;
using McK.GameOfLife.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McK.GameOfLife.TestCases
{
    [TestClass]
    public class CellFactoryTest
    {
        [TestMethod]
        public void TestFactoryInstance()
        {
            var factory = new CellFactory(4, 4);
            Assert.IsNotNull(factory);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestFactoryLowerLimit()
        {
            try
            {
                var factory = new CellFactory(3, 4);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("row and column size should not be less than 4", exception.Message);
                throw;
            }
        }

        [TestMethod]
        public void TestCreateCell()
        {
            // in 4x4 cells are fixed
            //00 top left
            //01 top, 02 top , 03 top right
            //10 and 20 left 
            //11 21 normal, 12 22 normal, 13 23 right
            //30 bottom left
            // 31 bottom, 32 bottom, 33 bottom right

            var factory = new CellFactory(4, 4);
            Assert.IsTrue(factory.CreateCell(0,0) is TopLeftCell);
            Assert.IsTrue(factory.CreateCell(0, 1) is TopCell);
            Assert.IsTrue(factory.CreateCell(0, 2) is TopCell);
            Assert.IsTrue(factory.CreateCell(0, 3) is TopRightCell);
            Assert.IsTrue(factory.CreateCell(1, 0) is LeftCell);
            Assert.IsFalse(factory.CreateCell(1,1).GetType().IsSubclassOf(typeof(Cell)));
            Assert.IsFalse(factory.CreateCell(1, 2).GetType().IsSubclassOf(typeof(Cell)));
            Assert.IsTrue(factory.CreateCell(1, 3) is RightCell);
            Assert.IsTrue(factory.CreateCell(2, 0) is LeftCell);
            Assert.IsFalse(factory.CreateCell(2, 1).GetType().IsSubclassOf(typeof(Cell)));
            Assert.IsFalse(factory.CreateCell(2, 2).GetType().IsSubclassOf(typeof(Cell)));
            Assert.IsTrue(factory.CreateCell(2, 3) is RightCell);
            Assert.IsTrue(factory.CreateCell(3, 0) is BottomLeftCell);
            Assert.IsTrue(factory.CreateCell(3, 1) is BottomCell);
            Assert.IsTrue(factory.CreateCell(3, 2) is BottomCell);
            Assert.IsTrue(factory.CreateCell(3, 3) is BottomRightCell);
        }

    }
}