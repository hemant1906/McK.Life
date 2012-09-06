namespace McK.GameOfLife.Model.Cells
{
    internal class BottomCell : AbstractCell
    {
        public override bool CanHaveBottom
        {
            get { return false; }
        }

        public override bool CanHaveBottomLeft
        {
            get { return false; }
        }

        public override bool CanHaveBottomRight
        {
            get { return false; }
        }


    }
}