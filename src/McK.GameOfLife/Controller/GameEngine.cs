using System;
using System.Text.RegularExpressions;
using McK.GameOfLife.Model;
using McK.GameOfLife.View;

namespace McK.GameOfLife.Controller
{
    public class GameEngine
    {
        private readonly GameController _gameController;
        private readonly int _height;
        private readonly IPlayField _playField;
        private readonly IRenderer _renderer;
        private readonly int _width;

        public GameEngine(int width, int height)
        {
            _width = width;
            _height = height;


            _playField = new PlayFieldGrid(width, height);
            IGameRule rule = new ClassicRule();
            _gameController = new GameController(_playField, rule);
            _renderer = new ConsoleRenderer();
        }

        public void InitializeGame(string initialState)
        {
            var regEx = new Regex("^[0-1]*$");
            if (!regEx.IsMatch(initialState))
                throw new ArgumentException("Input should be in 011101 format");
            if (initialState.Length == 0 || initialState.Length > _width*_height)
                throw new ArgumentException("Input length is not correct");
            _gameController.SetState(initialState);
        }

        public void Move(uint generations)
        {
            _gameController.MoveToGenration(generations);
        }

        public void Render()
        {
            _renderer.Render(_playField);
        }

        public int GetCurrentGameGeneration()
        {
            return _playField.CurrentGeneration;
        }
    }
}