using System;

namespace McK.GameOfLife.Model
{
    internal class CellFactory
    {
        private readonly int _x;
        private readonly int _y;

        public CellFactory(int gridX, int gridY)
        {
            if (gridX < 4 || gridY < 4)
                throw new ArgumentException("griX and gridY size should not be less than 4");

            _x = gridX;
            _y = gridY;
        }


        // create cell on basis of the location of cell
        public Cell CreateCell(int x, int y)
        {
            if (x == 0) // first line will have all top 
            {
                if (y == 0) // top left
                    return new TopLeftCell();
                if (y == _y - 1) // top right
                    return new TopRightCell();
                return new TopCell();
            }
            if (x == _x - 1) // bottom line will have all bottom
            {
                if (y == 0) // bottom left
                    return new BottomLeftCell();
                if (y == _y - 1) // bottom right
                    return new BottomRightCell();
                return new BottomCell();
            }
            if (y == 0) // all left items
                return new LeftCell();
            if (y == _y - 1) // all right items
                return new RightCell();
            return new Cell();
        }
    }
}