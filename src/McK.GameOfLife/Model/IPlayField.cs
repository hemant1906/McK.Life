using System.Collections.Generic;

namespace McK.GameOfLife.Model
{
    public interface IPlayField
    {
        int Width { get; }
        int Height { get; }

        int CurrentGeneration { get; }
        void IncreaseGeneration(int increaseBy);


        void InitializePlayField(string state);
        Cell[,] GetCells();
        Cell GetCell(int x, int y);
        List<Cell> GetNeighbours(int x, int y);
        IPlayField Clone();
    }
}