using System.Collections.Generic;
using McK.GameOfLife.Model.Cells;

namespace McK.GameOfLife.Model.Playfields
{
    public interface IPlayField
    {
        int Columns { get; }
        int Rows { get; }

        int CurrentGeneration { get; }
        void IncreaseGeneration(int increaseBy);


        void InitializePlayField(string state);
        AbstractCell[,] GetCells();
        AbstractCell GetCell(int row, int column);
        List<AbstractCell> GetNeighbours(int row, int column);
        IPlayField Clone();
    }
}