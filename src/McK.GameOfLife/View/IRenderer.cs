using McK.GameOfLife.Model;

namespace McK.GameOfLife.View
{
    internal interface IRenderer
    {
        void Render(IPlayField playField);
    }
}