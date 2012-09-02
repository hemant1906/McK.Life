using System;
using System.Collections.Generic;
using System.Linq;

namespace McK.GameOfLife.Model
{
    internal class ClassicRule : IGameRule
    {
        #region IGameRule Members

        public void ApplyRule(Cell cell, List<Cell> neighbours)
        {
            if (cell == null)
                throw new ArgumentNullException("cell");
            if (neighbours == null)
                throw new ArgumentNullException("neighbours");

            int alive = neighbours.Count(neighbour => neighbour.IsAlive);

            if ((alive == 2 && cell.IsAlive) || alive == 3)
                cell.ShouldLive();
            else
                cell.ShouldDie();
        }

        #endregion
    }
}