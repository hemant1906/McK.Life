namespace McK.GameOfLife.Model.Cells
{
    internal class BottomLeftCell : AbstractCell
    {
        public override bool CanHaveBottom
        {
            get { return false; }
        }

        public override bool CanHaveBottomLeft
        {
            get { return false; }
        }

        public override bool CanHaveLeft
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