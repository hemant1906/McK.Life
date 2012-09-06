using McK.GameOfLife.Model.Playfields;

namespace McK.GameOfLife.View
{
    internal interface IRenderer
    {
        void Render(IPlayField playField);
    }
}