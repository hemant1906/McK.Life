namespace McK.GameOfLife.Model.Cells
{
    internal class RightCell : AbstractCell
    {
        public override bool CanHaveRight
        {
            get { return false; }
        }

        public override bool CanHaveBottomRight
        {
            get { return false; }
        }

        public override bool CanHaveTopRight
        {
            get { return false; }
        }


    }
}