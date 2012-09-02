using McK.GameOfLife.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McK.GameOfLife.TestCases
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void TestCellBirth()
        {
            var cell = new Cell();
            cell.ShouldLive();
            Assert.AreEqual(1, cell.CurrentGeneration);
            cell.ShouldLive();
            Assert.AreEqual(2, cell.CurrentGeneration);
        }


        [TestMethod]
        public void TestCellDeath()
        {
            var cell = new Cell();
            cell.ShouldDie();
            Assert.AreEqual(0, cell.CurrentGeneration);
        }

        [TestMethod]
        public void TestCellNeighbourAccessibility()
        {
            var cell = new Cell();
            Assert.AreEqual(true, cell.CanHaveBottom);
            Assert.AreEqual(true, cell.CanHaveBottomLeft);
            Assert.AreEqual(true, cell.CanHaveBottomRight);
            Assert.AreEqual(true, cell.CanHaveLeft);
            Assert.AreEqual(true, cell.CanHaveRight);
            Assert.AreEqual(true, cell.CanHaveTopLeft);
            Assert.AreEqual(true, cell.CanHaveTopRight);
            Assert.AreEqual(true, cell.CanHaveTop);
        }

        [TestMethod]
        public void TestCellCloning()
        {
            var cell = new Cell();
            cell.ShouldLive();
            Cell cloneCell = cell.Clone();
            CompareClones(cell, cloneCell);
        }


        [TestMethod]
        public void TestTopLeftCellCloning()
        {
            var cell = new TopLeftCell();
            cell.ShouldLive();
            Cell cloneCell = cell.Clone();
            CompareClones(cell, cloneCell);
        }

        [TestMethod]
        public void TestTopCellCloning()
        {
            var cell = new TopCell();
            cell.ShouldLive();
            Cell cloneCell = cell.Clone();
            CompareClones(cell, cloneCell);
        }

        [TestMethod]
        public void TestTopRightCellCloning()
        {
            var cell = new TopRightCell();
            cell.ShouldLive();
            Cell cloneCell = cell.Clone();
            CompareClones(cell, cloneCell);
        }

        [TestMethod]
        public void TestLeftCellCloning()
        {
            var cell = new LeftCell();
            cell.ShouldLive();
            Cell cloneCell = cell.Clone();
            CompareClones(cell, cloneCell);
        }

        [TestMethod]
        public void TestRighCellCloning()
        {
            var cell = new RightCell();
            cell.ShouldLive();
            Cell cloneCell = cell.Clone();
            CompareClones(cell, cloneCell);
        }

        [TestMethod]
        public void TestBottomLeftCellCloning()
        {
            var cell = new BottomLeftCell();
            cell.ShouldLive();
            Cell cloneCell = cell.Clone();
            CompareClones(cell, cloneCell);
        }

        [TestMethod]
        public void TestBottomCellCloning()
        {
            var cell = new BottomCell();
            cell.ShouldLive();
            Cell cloneCell = cell.Clone();
            CompareClones(cell, cloneCell);
        }

        [TestMethod]
        public void TestBottomRightCellCloning()
        {
            var cell = new BottomRightCell();
            cell.ShouldLive();
            Cell cloneCell = cell.Clone();
            CompareClones(cell, cloneCell);
        }

        private void CompareClones(Cell cell, Cell cloneCell)
        {
            Assert.AreEqual(cell.CanHaveBottom, cloneCell.CanHaveBottom);
            Assert.AreEqual(cell.CanHaveBottomLeft, cloneCell.CanHaveBottomLeft);
            Assert.AreEqual(cell.CanHaveBottomRight, cloneCell.CanHaveBottomRight);
            Assert.AreEqual(cell.CanHaveLeft, cloneCell.CanHaveLeft);
            Assert.AreEqual(cell.CanHaveRight, cloneCell.CanHaveRight);
            Assert.AreEqual(cell.CanHaveTopLeft, cloneCell.CanHaveTopLeft);
            Assert.AreEqual(cell.CanHaveTopRight, cloneCell.CanHaveTopRight);
            Assert.AreEqual(cell.CanHaveTop, cloneCell.CanHaveTop);
            Assert.AreEqual(cell.CurrentGeneration, cloneCell.CurrentGeneration);
        }


        [TestMethod]
        public void TestBottomCellNeighbourAccessibility()
        {
            var cell = new BottomCell();
            Assert.AreEqual(false, cell.CanHaveBottom);
            Assert.AreEqual(false, cell.CanHaveBottomLeft);
            Assert.AreEqual(false, cell.CanHaveBottomRight);
            Assert.AreEqual(true, cell.CanHaveLeft);
            Assert.AreEqual(true, cell.CanHaveRight);
            Assert.AreEqual(true, cell.CanHaveTopLeft);
            Assert.AreEqual(true, cell.CanHaveTopRight);
            Assert.AreEqual(true, cell.CanHaveTop);
        }

        [TestMethod]
        public void TestBottomLeftCellNeighbourAccessibility()
        {
            var cell = new BottomLeftCell();
            Assert.AreEqual(false, cell.CanHaveBottom);
            Assert.AreEqual(false, cell.CanHaveBottomLeft);
            Assert.AreEqual(false, cell.CanHaveBottomRight);
            Assert.AreEqual(false, cell.CanHaveLeft);
            Assert.AreEqual(true, cell.CanHaveRight);
            Assert.AreEqual(false, cell.CanHaveTopLeft);
            Assert.AreEqual(true, cell.CanHaveTopRight);
            Assert.AreEqual(true, cell.CanHaveTop);
        }


        [TestMethod]
        public void TestBottomRightNeighbourAccessibility()
        {
            var cell = new BottomRightCell();
            Assert.AreEqual(false, cell.CanHaveBottom);
            Assert.AreEqual(false, cell.CanHaveBottomLeft);
            Assert.AreEqual(false, cell.CanHaveBottomRight);
            Assert.AreEqual(true, cell.CanHaveLeft);
            Assert.AreEqual(false, cell.CanHaveRight);
            Assert.AreEqual(true, cell.CanHaveTopLeft);
            Assert.AreEqual(false, cell.CanHaveTopRight);
            Assert.AreEqual(true, cell.CanHaveTop);
        }


        [TestMethod]
        public void TestTopCellNeighbourAccessibility()
        {
            var cell = new TopCell();
            Assert.AreEqual(true, cell.CanHaveBottom);
            Assert.AreEqual(true, cell.CanHaveBottomLeft);
            Assert.AreEqual(true, cell.CanHaveBottomRight);
            Assert.AreEqual(true, cell.CanHaveLeft);
            Assert.AreEqual(true, cell.CanHaveRight);
            Assert.AreEqual(false, cell.CanHaveTopLeft);
            Assert.AreEqual(false, cell.CanHaveTopRight);
            Assert.AreEqual(false, cell.CanHaveTop);
        }

        [TestMethod]
        public void TestTopLeftCellNeighbourAccessibility()
        {
            var cell = new TopLeftCell();
            Assert.AreEqual(true, cell.CanHaveBottom);
            Assert.AreEqual(false, cell.CanHaveBottomLeft);
            Assert.AreEqual(true, cell.CanHaveBottomRight);
            Assert.AreEqual(false, cell.CanHaveLeft);
            Assert.AreEqual(true, cell.CanHaveRight);
            Assert.AreEqual(false, cell.CanHaveTopLeft);
            Assert.AreEqual(false, cell.CanHaveTopRight);
            Assert.AreEqual(false, cell.CanHaveTop);
        }


        [TestMethod]
        public void TestTopRightNeighbourAccessibility()
        {
            var cell = new TopRightCell();
            Assert.AreEqual(true, cell.CanHaveBottom);
            Assert.AreEqual(true, cell.CanHaveBottomLeft);
            Assert.AreEqual(false, cell.CanHaveBottomRight);
            Assert.AreEqual(true, cell.CanHaveLeft);
            Assert.AreEqual(false, cell.CanHaveRight);
            Assert.AreEqual(false, cell.CanHaveTopLeft);
            Assert.AreEqual(false, cell.CanHaveTopRight);
            Assert.AreEqual(false, cell.CanHaveTop);
        }


        [TestMethod]
        public void TestLeftCellNeighbourAccessibility()
        {
            var cell = new LeftCell();
            Assert.AreEqual(true, cell.CanHaveBottom);
            Assert.AreEqual(false, cell.CanHaveBottomLeft);
            Assert.AreEqual(true, cell.CanHaveBottomRight);
            Assert.AreEqual(false, cell.CanHaveLeft);
            Assert.AreEqual(true, cell.CanHaveRight);
            Assert.AreEqual(false, cell.CanHaveTopLeft);
            Assert.AreEqual(true, cell.CanHaveTopRight);
            Assert.AreEqual(true, cell.CanHaveTop);
        }


        [TestMethod]
        public void TestRightCellNeighbourAccessibility()
        {
            var cell = new RightCell();
            Assert.AreEqual(true, cell.CanHaveBottom);
            Assert.AreEqual(true, cell.CanHaveBottomLeft);
            Assert.AreEqual(false, cell.CanHaveBottomRight);
            Assert.AreEqual(true, cell.CanHaveLeft);
            Assert.AreEqual(false, cell.CanHaveRight);
            Assert.AreEqual(true, cell.CanHaveTopLeft);
            Assert.AreEqual(false, cell.CanHaveTopRight);
            Assert.AreEqual(true, cell.CanHaveTop);
        }
    }
}