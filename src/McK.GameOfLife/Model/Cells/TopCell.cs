namespace McK.GameOfLife.Model.Cells
{
    internal class TopCell : AbstractCell
    {
        public override bool CanHaveTopRight
        {
            get { return false; }
        }

        public override bool CanHaveTopLeft
        {
            get { return false; }
        }

        public override bool CanHaveTop
        {
            get { return false; }
        }
    }
}