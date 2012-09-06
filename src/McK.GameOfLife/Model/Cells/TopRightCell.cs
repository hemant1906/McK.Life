namespace McK.GameOfLife.Model.Cells
{
    internal class TopRightCell : AbstractCell
    {
        public override bool CanHaveRight
        {
            get { return false; }
        }

        public override bool CanHaveTopRight
        {
            get { return false; }
        }

        public override bool CanHaveTop
        {
            get { return false; }
        }

        public override bool CanHaveTopLeft
        {
            get { return false; }
        }

        public override bool CanHaveBottomRight
        {
            get { return false; }
        }

    }
}