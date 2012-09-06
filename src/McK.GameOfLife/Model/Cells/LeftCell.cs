namespace McK.GameOfLife.Model.Cells
{
    internal class LeftCell : AbstractCell
    {
        public override bool CanHaveLeft
        {
            get { return false; }
        }

        public override bool CanHaveBottomLeft
        {
            get { return false; }
        }

        public override bool CanHaveTopLeft
        {
            get { return false; }
        }

    }
}