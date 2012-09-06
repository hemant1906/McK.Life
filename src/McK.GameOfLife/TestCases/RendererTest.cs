using System;
using System.IO;
using McK.GameOfLife.Model;
using McK.GameOfLife.Model.Cells;
using McK.GameOfLife.Model.Playfields;
using McK.GameOfLife.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace McK.GameOfLife.TestCases
{
    [TestClass]
    public class RendererTest
    {
        [TestMethod]
        public void TestRender()
        {
            IRenderer render = new ConsoleRenderer();
            ICellFactory factory = new GridCellFactory(4, 4);
            IPlayField playField = new GridPlayField(factory,4, 4);
            playField.InitializePlayField("0010001000100010");
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader(""))
                {
                    Console.SetIn(sr);

                    render.Render(playField);

                    string expected = string.Format("  # {0}  # {1}  # {2}  # {3}", Environment.NewLine,
                                                    Environment.NewLine, Environment.NewLine, Environment.NewLine);
                    /*  
                    * | | |#| |
                    * | | |#| |
                    * | | |#| |
                    * | | |#| |
                    */
                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }
    }
}