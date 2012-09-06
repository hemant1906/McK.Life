using System.Collections.Generic;
using McK.GameOfLife.Model.Cells;

namespace McK.GameOfLife.Model.Rules
{
    internal interface IGameRule
    {
        void ApplyRule(AbstractCell cell, List<AbstractCell> neighbours);
    }
}