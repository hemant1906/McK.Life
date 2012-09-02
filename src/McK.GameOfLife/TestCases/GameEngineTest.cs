using System;
using System.IO;
using McK.GameOfLife.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McK.GameOfLife.TestCases
{
    [TestClass]
    public class GameEngineTest
    {
        [TestMethod]
        public void TestGameEngineInstance()
        {
            var engine = new GameEngine(4, 4);
            Assert.IsNotNull(engine);
        }

        [TestMethod]
        public void TestInitializeGame()
        {
            var engine = new GameEngine(4, 4);
            engine.InitializeGame("1010010100101001");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestStateArgumentException()
        {
            try
            {
                var engine = new GameEngine(4, 4);
                engine.InitializeGame("1010010100101021");
            }
            catch (Exception exception)
            {
                Assert.AreEqual("Input should be in 011101 format", exception.Message);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestStateArgumentExcptionLowerLimit()
        {
            try
            {
                var engine = new GameEngine(4, 4);
                engine.InitializeGame("");
            }
            catch (Exception exception)
            {
                Assert.AreEqual("Input length is not correct", exception.Message);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestStateArgumentExcptionUpperLimit()
        {
            try
            {
                var engine = new GameEngine(4, 4);
                engine.InitializeGame("11111111111111111");
            }
            catch (Exception exception)
            {
                Assert.AreEqual("Input length is not correct", exception.Message);
                throw;
            }
        }

        [TestMethod]
        public void TestGameEngineMove()
        {
            var engine = new GameEngine(4, 4);
            engine.InitializeGame("0100101001");
            engine.Move(1);
        }


        [TestMethod]
        public void TestGameEngineRender()
        {
            var engine = new GameEngine(4, 4);
            engine.InitializeGame("0100101001");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader(""))
                {
                    Console.SetIn(sr);

                    engine.Render();

                    string expected = string.Format(" #  {0}# # {1} #  {2}    {3}", Environment.NewLine,
                                                    Environment.NewLine, Environment.NewLine, Environment.NewLine);
                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }

        [TestMethod]
        public void TestGameGeneration()
        {
            var engine = new GameEngine(4, 4);
            engine.InitializeGame("1111111111111111");
            Assert.AreEqual(0, engine.GetCurrentGameGeneration());
            engine.Move(5);
            Assert.AreEqual(5, engine.GetCurrentGameGeneration());
        }
    }
}