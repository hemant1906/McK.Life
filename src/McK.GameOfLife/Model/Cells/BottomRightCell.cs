namespace McK.GameOfLife.Model.Cells
{
    internal class BottomRightCell : AbstractCell
    {
        public override bool CanHaveBottom
        {
            get { return false; }
        }

        public override bool CanHaveRight
        {
            get { return false; }
        }

        public override bool CanHaveBottomRight
        {
            get { return false; }
        }

        public override bool CanHaveBottomLeft
        {
            get { return false; }
        }

        public override bool CanHaveTopRight
        {
            get { return false; }
        }


    }
}