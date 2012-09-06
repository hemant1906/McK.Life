namespace McK.GameOfLife.Model.Cells
{
    internal class TopLeftCell : AbstractCell
    {
        public override bool CanHaveLeft
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

        public override bool CanHaveTopRight
        {
            get { return false; }
        }

        public override bool CanHaveBottomLeft
        {
            get { return false; }
        }


    }
}