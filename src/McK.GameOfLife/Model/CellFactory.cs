using System;

namespace McK.GameOfLife.Model
{
    internal class CellFactory
    {
        private readonly int _rows;
        private readonly int _columns;

        public CellFactory(int rows, int columns)
        {
            if (rows < 4 || columns < 4)
                throw new ArgumentException("row and column size should not be less than 4");

            _rows = rows;
            _columns = columns;
        }


        // create cell on basis of the location of cell
        public Cell CreateCell(int row, int column)
        {
            if (row == 0) // first line will have all top 
            {
                if (column == 0) // top left
                    return new TopLeftCell();
                if (column == _columns - 1) // top right
                    return new TopRightCell();
                return new TopCell();
            }
            if (row == _rows - 1) // bottom line will have all bottom
            {
                if (column == 0) // bottom left
                    return new BottomLeftCell();
                if (column == _columns - 1) // bottom right
                    return new BottomRightCell();
                return new BottomCell();
            }
            if (column == 0) // all left items
                return new LeftCell();
            if (column == _columns - 1) // all right items
                return new RightCell();
            return new Cell();
        }
    }
}