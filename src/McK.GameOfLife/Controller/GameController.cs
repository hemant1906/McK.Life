using System;
using System.Text;
using McK.GameOfLife.Model.Playfields;
using McK.GameOfLife.Model.Rules;

namespace McK.GameOfLife.Controller
{
    internal class GameController
    {
        private readonly IGameRule _gameRule;
        private readonly IPlayField _playField;

        public GameController(IPlayField playField, IGameRule gameRule)
        {
            if (playField == null)
                throw new ArgumentNullException("playField");

            if (gameRule == null)
                throw new ArgumentNullException("gameRule");

            _playField = playField;
            _gameRule = gameRule;
        }

        public void SetState(string initialState)
        {
            _playField.InitializePlayField(initialState);
        }


        public string GetState()
        {
            var builder = new StringBuilder();
            for (int row = 0; row < _playField.Rows; row++)
                for (int column = 0; column < _playField.Columns; column++)
                {
                    builder.Append(_playField.GetCell(row, column).IsAlive ? "1" : "0");
                }
            return builder.ToString();
        }

        public void MoveToGenration(uint generation)
        {
            if (generation != 0)
            {
                MoveToNextGeneration();
                MoveToGenration(--generation);
            }
        }

        public void MoveToNextGeneration()
        {
            IPlayField oldGeneration = _playField.Clone();
            for (int row = 0; row < _playField.Rows; row++)
                for (int column = 0; column < _playField.Columns; column++)
                    _gameRule.ApplyRule(_playField.GetCell(row, column), oldGeneration.GetNeighbours(row, column));
            _playField.IncreaseGeneration(1);
            // parallel implementation

            #region

            /*
            Parallel.For(0, oldGeneration.Width,
                         i =>
                         Parallel.For(0, oldGeneration.Height,
                                      j => _gameRule.ApplyRule(_playField.GetCell(row, column),
                                                               oldGeneration.GetNeighbours(row, column))
                             )
                );
             * */

            #endregion
        }
    }
}