using System;
using System.Collections.Generic;
using McK.GameOfLife.Model.Cells;

namespace McK.GameOfLife.Model.Playfields
{
    internal class GridPlayField : IPlayField
    {
        private readonly AbstractCell[,] _internalGrid;
        private readonly int _rows;
        private readonly int _columns;
        private readonly ICellFactory _cellFactory;

        //create playfield grid of x by y size Minimum is 4x4
        public GridPlayField(ICellFactory cellFactory, int rows, int columns)
        {
            if (rows < 4 || columns < 4)
                throw new ArgumentException("rows and columns value can't ne less than 4");

            _rows = rows;
            _columns = columns;
            _internalGrid = new AbstractCell[rows,columns];
            _cellFactory = cellFactory;
        }

        #region IPlayField Members

        public int Columns
        {
            get { return _columns; }
        }

        public int Rows
        {
            get { return _rows; }
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

            for (int row = 0; row < _rows; row++)
                for (int column = 0; column < _columns; column++)
                {
                    _internalGrid[row, column] = _cellFactory.CreateCell(row, column);
                    if (stateArray.Length > TwoToOneDim(_columns, row, column)) //we have state for this
                    {
                        if (stateArray[TwoToOneDim(_columns, row, column)] == '1')
                            _internalGrid[row, column].ShouldLive();
                        else
                            _internalGrid[row, column].ShouldDie();
                    }
                }
        }


        public AbstractCell[,] GetCells()
        {
            return _internalGrid;
        }

        public AbstractCell GetCell(int row, int column)
        {
            ValidateIndex(row, column);
            return _internalGrid[row, column];
        }


        public List<AbstractCell> GetNeighbours(int row, int column)
        {
            AbstractCell cell = GetCell(row, column);
            var neighbours = new List<AbstractCell>();
            if (cell.CanHaveTopLeft)
                neighbours.Add(GetCell(row - 1, column - 1).Clone());
            if (cell.CanHaveTop)
                neighbours.Add(GetCell(row - 1, column).Clone());
            if (cell.CanHaveTopRight)
                neighbours.Add(GetCell(row - 1, column + 1).Clone());
            if (cell.CanHaveLeft)
                neighbours.Add(GetCell(row, column - 1).Clone());
            if (cell.CanHaveRight)
                neighbours.Add(GetCell(row, column + 1).Clone());
            if (cell.CanHaveBottomLeft)
                neighbours.Add(GetCell(row + 1, column - 1).Clone());
            if (cell.CanHaveBottom)
                neighbours.Add(GetCell(row + 1, column).Clone());
            if (cell.CanHaveBottomRight)
                neighbours.Add(GetCell(row + 1, column + 1).Clone());
            return neighbours;
        }

        public IPlayField Clone()
        {
            ICellFactory cellFactory = new GridCellFactory(_rows,_columns);
            IPlayField playFieldGrid = new GridPlayField(cellFactory,_rows, _columns);
            AbstractCell[,] gridCopy = playFieldGrid.GetCells(); // get reference to this class's grid
            for (int row = 0; row < _rows; row++)
                for (int column = 0; column < _columns; column++)
                    gridCopy[row, column] = GetCell(row, column).Clone();

            playFieldGrid.IncreaseGeneration(CurrentGeneration);

            return playFieldGrid;
        }

        #endregion

        private int TwoToOneDim(int columns, int row, int column)
        {
            return row*columns + column;
        }

        private void ValidateIndex(int row, int column)
        {
            if (row < 0 || column < 0 || row >= _rows || column >= _columns)
                throw new IndexOutOfRangeException(
                    string.Format("row should be between 0 to {0} and column should be between 0 to {1}", _rows - 1, _columns - 1));
        }
    }
}