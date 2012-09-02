namespace McK.GameOfLife.Model
{
    internal class BottomRightCell : Cell
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

        public override Cell Clone()
        {
            var clone = new BottomRightCell {IsAlive = IsAlive, CurrentGeneration = CurrentGeneration};
            return clone;
        }
    }
}