namespace McK.GameOfLife.Model
{
    internal class TopRightCell : Cell
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

        public override Cell Clone()
        {
            var clone = new TopRightCell {IsAlive = IsAlive, CurrentGeneration = CurrentGeneration};
            return clone;
        }
    }
}