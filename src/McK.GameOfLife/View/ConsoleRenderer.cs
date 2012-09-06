using System;
using System.Text;
using McK.GameOfLife.Model.Playfields;

namespace McK.GameOfLife.View
{
    internal class ConsoleRenderer : IRenderer
    {
        #region IRenderer Members

        public void Render(IPlayField playField)
        {
            var output = new StringBuilder();
            for (int row = 0; row < playField.Rows; row++)
                for (int column = 0; column < playField.Columns; column++)
                {
                    output.Append(playField.GetCell(row, column).IsAlive ? "#" : " ");
                    if (column == playField.Columns - 1)
                        output.Append(Environment.NewLine);
                }

            Console.Write(output.ToString());
        }

        #endregion
    }
}