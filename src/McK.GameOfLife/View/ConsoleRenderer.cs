using System;
using System.Text;
using McK.GameOfLife.Model;

namespace McK.GameOfLife.View
{
    internal class ConsoleRenderer : IRenderer
    {
        #region IRenderer Members

        public void Render(IPlayField playField)
        {
            var output = new StringBuilder();
            for (int i = 0; i < playField.Height; i++)
                for (int j = 0; j < playField.Width; j++)
                {
                    output.Append(playField.GetCell(i, j).IsAlive ? "#" : " ");
                    if (j == playField.Width - 1)
                        output.Append(Environment.NewLine);
                }

            Console.Write(output.ToString());
        }

        #endregion
    }
}