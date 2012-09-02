namespace McK.GameOfLife.Model
{
    internal class TopLeftCell : Cell
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

        public override Cell Clone()
        {
            var clone = new TopLeftCell();
            clone.IsAlive = IsAlive;
            clone.CurrentGeneration = CurrentGeneration;
            return clone;
        }
    }
}