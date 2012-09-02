using System;
using System.Collections.Generic;
using McK.GameOfLife.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McK.GameOfLife.TestCases
{
    [TestClass]
    public class RuleTest
    {
        [TestMethod]
        public void TestClassicBecomeAliveRule()
        {
            IGameRule rule = new ClassicRule();
            var cell = new Cell();
            Assert.AreEqual(false, cell.IsAlive);
            Assert.AreEqual(0, cell.CurrentGeneration);
            var cells = new List<Cell> {new Cell(), new Cell(), new Cell(), new Cell()};
            cells[0].ShouldLive();
            cells[1].ShouldLive();
            cells[2].ShouldLive();
            rule.ApplyRule(cell, cells);
            Assert.AreEqual(true, cell.IsAlive);
            Assert.AreEqual(1, cell.CurrentGeneration);
        }

        [TestMethod]
        public void TestClassicDieOverPopulationRule()
        {
            IGameRule rule = new ClassicRule();
            var cell = new Cell();
            cell.ShouldLive();
            Assert.AreEqual(true, cell.IsAlive);
            Assert.AreEqual(1, cell.CurrentGeneration);
            var cells = new List<Cell> {new Cell(), new Cell(), new Cell(), new Cell()};
            cells[0].ShouldLive();
            cells[1].ShouldLive();
            cells[2].ShouldLive();
            cells[3].ShouldLive();
            rule.ApplyRule(cell, cells);
            Assert.AreEqual(false, cell.IsAlive);
            Assert.AreEqual(0, cell.CurrentGeneration);
        }

        [TestMethod]
        public void TestClassicDieUnderPopulationRule()
        {
            IGameRule rule = new ClassicRule();
            var cell = new Cell();
            cell.ShouldLive();
            Assert.AreEqual(true, cell.IsAlive);
            Assert.AreEqual(1, cell.CurrentGeneration);
            var cells = new List<Cell> {new Cell(), new Cell(), new Cell(), new Cell()};
            cells[0].ShouldLive();
            rule.ApplyRule(cell, cells);
            Assert.AreEqual(false, cell.IsAlive);
            Assert.AreEqual(0, cell.CurrentGeneration);
        }


        [TestMethod]
        public void TestClassicSustainLifeRule()
        {
            IGameRule rule = new ClassicRule();
            var cell = new Cell();
            cell.ShouldLive();
            Assert.AreEqual(true, cell.IsAlive);
            Assert.AreEqual(1, cell.CurrentGeneration);
            var cells = new List<Cell> {new Cell(), new Cell(), new Cell(), new Cell()};
            cells[0].ShouldLive();
            cells[1].ShouldLive();
            rule.ApplyRule(cell, cells);
            Assert.AreEqual(true, cell.IsAlive);
            Assert.AreEqual(2, cell.CurrentGeneration);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestRuleCellNullException()
        {
            try
            {
                IGameRule rule = new ClassicRule();
                rule.ApplyRule(null, new List<Cell>());
            }
            catch (Exception exception)
            {
                Assert.AreEqual("Value cannot be null.\r\nParameter name: cell", exception.Message);

                throw;
            }
        }


        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestRuleNeighboursNullException()
        {
            try
            {
                IGameRule rule = new ClassicRule();
                rule.ApplyRule(new Cell(), null);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("Value cannot be null.\r\nParameter name: neighbours", exception.Message);

                throw;
            }
        }
    }
}