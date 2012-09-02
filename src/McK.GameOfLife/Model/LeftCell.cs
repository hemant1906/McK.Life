namespace McK.GameOfLife.Model
{
    internal class LeftCell : Cell
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

        public override Cell Clone()
        {
            var clone = new LeftCell();
            clone.IsAlive = IsAlive;
            clone.CurrentGeneration = CurrentGeneration;
            return clone;
        }
    }
}