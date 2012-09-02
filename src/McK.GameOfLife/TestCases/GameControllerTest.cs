using System;
using McK.GameOfLife.Controller;
using McK.GameOfLife.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McK.GameOfLife.TestCases
{
    [TestClass]
    public class GameControllerTest
    {
        [TestMethod]
        public void TestGameControllerInstance()
        {
            IPlayField playField = new PlayFieldGrid(4, 4);
            IGameRule rule = new ClassicRule();
            var controller = new GameController(playField, rule);
            Assert.IsNotNull(controller);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestGameControllerInstanceNullPlayField()
        {
            try
            {
                IGameRule rule = new ClassicRule();
                var controller = new GameController(null, rule);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("Value cannot be null.\r\nParameter name: playField", exception.Message);
                throw;
            }
        }


        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestGameControllerInstanceNullGameRule()
        {
            try
            {
                IPlayField playField = new PlayFieldGrid(4, 4);

                var controller = new GameController(playField, null);
            }
            catch (Exception exception)
            {
                Assert.AreEqual("Value cannot be null.\r\nParameter name: gameRule", exception.Message);
                throw;
            }
        }

        [TestMethod]
        public void TestGameFieldInitialization()
        {
            IPlayField playField = new PlayFieldGrid(4, 4);
            IGameRule rule = new ClassicRule();
            var controller = new GameController(playField, rule);
            string state = "0100111011001010";
            controller.SetState(state);

            Assert.AreEqual(controller.GetState(), state);
        }

        [TestMethod]
        public void TestNextGeneration()
        {
            IPlayField playField = new PlayFieldGrid(4, 4);
            IGameRule rule = new ClassicRule();
            var controller = new GameController(playField, rule);
            const string state = "0100010001000000"; // blinker 
            const string nextState = "0000111000000000";
            controller.SetState(state);
            controller.MoveToNextGeneration();
            Assert.AreEqual(nextState, controller.GetState());
        }

        [TestMethod]
        public void TestMoveGeneration()
        {
            IPlayField playField = new PlayFieldGrid(4, 4);
            IGameRule rule = new ClassicRule();
            var controller = new GameController(playField, rule);
            const string state = "0100010001000000"; // blinker 
            const string nextState = "0000111000000000";
            controller.SetState(state);
            controller.MoveToGenration(2);
            Assert.AreEqual(state, controller.GetState());
            controller.MoveToGenration(1);
            Assert.AreEqual(nextState, controller.GetState());
        }
    }
}