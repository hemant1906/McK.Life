using System.Collections.Generic;

namespace McK.GameOfLife.Model
{
    internal interface IGameRule
    {
        void ApplyRule(Cell cell, List<Cell> neighbours);
    }
}