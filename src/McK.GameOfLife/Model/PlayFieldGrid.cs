using System;
using System.Collections.Generic;

namespace McK.GameOfLife.Model
{
    internal class PlayFieldGrid : IPlayField
    {
        private readonly Cell[,] _internalGrid;
        private readonly int _x;
        private readonly int _y;

        //create playfield grid of x by y size Minimum is 4x4
        public PlayFieldGrid(int gridX, int gridY)
        {
            if (gridX < 4 || gridY < 4)
                throw new ArgumentException("gridX and gridY value can't ne less than 4");

            _x = gridX;
            _y = gridY;
            _internalGrid = new Cell[gridX,gridY];
        }

        #region IPlayField Members

        public int Width
        {
            get { return _x; }
        }

        public int Height
        {
            get { return _y; }
        }

        public int CurrentGeneration { get; private set; }

        public void IncreaseGeneration(int increaseBy)
        {
            CurrentGeneration = CurrentGeneration + increaseBy;
        }

        public void InitializePlayField(string state)
        {
            CurrentGeneration = 0; // reset the generation
            char[] stateArray = state.ToCharArray();

            var cellFactory = new CellFactory(_x, _y);
            for (int i = 0; i < _x; i++)
                for (int j = 0; j < _y; j++)
                {
                    _internalGrid[i, j] = cellFactory.CreateCell(i, j);
                    if (stateArray.Length > TwoToOneDim(_y, i, j)) //we have state for this
                    {
                        if (stateArray[TwoToOneDim(_y, i, j)] == '1')
                            _internalGrid[i, j].ShouldLive();
                        else
                            _internalGrid[i, j].ShouldDie();
                    }
                }
            //SetNeighbours();
        }

        /*
            private void SetNeighbours()
            {
                //// go through each cell and set it's neighbours
                //for (int i = 0; i < _x; i++)
                //    for (int j = 0; j < _y; j++)
                //    {
                //        var cell =  _internalGrid[i, j];
                //        if (!(cell is TopLeftCell || cell is LeftCell || cell is BottomLeftCell)) // these can't have left
                //            cell.Left = _internalGrid[i - 1, j];
                //        if (!(cell is TopLeftCell || cell is TopCell || cell is TopRightCell)) // these can't have top 
                //            cell.Top = _internalGrid[i, j - 1];
                //        if (!(cell is TopRightCell || cell is RightCell || cell is BottomRightCell)) // these can't have right
                //            cell.Right = _internalGrid[i + 1, j];
                //        if (!(cell is BottomLeftCell || cell is BottomCell || cell is BottomRightCell)) // these can't have Bottom
                //            cell.Bottom = _internalGrid[i, j + 1];
                //        if (!(cell is TopLeftCell)) // TopLeft can't have topLeft
                //            cell.TopLeft = _internalGrid[i - 1, j - 1];
                //        if (!(cell is TopRightCell)) // top right can't have top right
                //            cell.TopRight = _internalGrid[i - 1, j + 1];
                //        if (!(cell is BottomLeftCell)) // bottom left can't have bottom left
                //            cell.BottomLeft = _internalGrid[i + 1, j - 1];
                //        if (!(cell is BottomRightCell)) // bottom right can't have bottom right
                //            cell.BottomRight = _internalGrid[i + 1, j + 1];
                //    }
            }

        */

        public Cell[,] GetCells()
        {
            return _internalGrid;
        }

        public Cell GetCell(int x, int y)
        {
            ValidateIndex(x, y);
            return _internalGrid[x, y];
        }


        public List<Cell> GetNeighbours(int x, int y)
        {
            Cell cell = GetCell(x, y);
            var neighbours = new List<Cell>();
            if (cell.CanHaveTopLeft)
                neighbours.Add(GetCell(x - 1, y - 1).Clone());
            if (cell.CanHaveTop)
                neighbours.Add(GetCell(x - 1, y).Clone());
            if (cell.CanHaveTopRight)
                neighbours.Add(GetCell(x - 1, y + 1).Clone());
            if (cell.CanHaveLeft)
                neighbours.Add(GetCell(x, y - 1).Clone());
            if (cell.CanHaveRight)
                neighbours.Add(GetCell(x, y + 1).Clone());
            if (cell.CanHaveBottomLeft)
                neighbours.Add(GetCell(x + 1, y - 1).Clone());
            if (cell.CanHaveBottom)
                neighbours.Add(GetCell(x + 1, y).Clone());
            if (cell.CanHaveBottomRight)
                neighbours.Add(GetCell(x + 1, y + 1).Clone());
            return neighbours;
        }

        public IPlayField Clone()
        {
            IPlayField playFieldGrid = new PlayFieldGrid(_x, _y);
            Cell[,] gridCopy = playFieldGrid.GetCells(); // get reference to this class's grid
            for (int i = 0; i < _x; i++)
                for (int j = 0; j < _y; j++)
                    gridCopy[i, j] = GetCell(i, j).Clone();

            playFieldGrid.IncreaseGeneration(CurrentGeneration);

            return playFieldGrid;
        }

        #endregion

        private int TwoToOneDim(int width, int x, int y)
        {
            return x*width + y;
        }

        private void ValidateIndex(int x, int y)
        {
            if (x < 0 || y < 0 || x >= _x || y >= _y)
                throw new IndexOutOfRangeException(
                    string.Format("x should be between 0 to {0} and y should be between 0 to {1}", _x - 1, _y - 1));
        }
    }
}