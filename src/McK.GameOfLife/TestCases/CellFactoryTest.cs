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
                Assert.AreEqual("griX and gridY size should not be less than 4", exception.Message);
                throw;
            }
        }
    }
}