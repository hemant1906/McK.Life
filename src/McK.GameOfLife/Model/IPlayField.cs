using System.Collections.Generic;

namespace McK.GameOfLife.Model
{
    public interface IPlayField
    {
        int Columns { get; }
        int Rows { get; }

        int CurrentGeneration { get; }
        void IncreaseGeneration(int increaseBy);


        void InitializePlayField(string state);
        Cell[,] GetCells();
        Cell GetCell(int row, int column);
        List<Cell> GetNeighbours(int row, int column);
        IPlayField Clone();
    }
}