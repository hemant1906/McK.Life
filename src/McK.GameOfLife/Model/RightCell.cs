namespace McK.GameOfLife.Model
{
    internal class RightCell : Cell
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

        public override Cell Clone()
        {
            var clone = new RightCell();
            clone.IsAlive = IsAlive;
            clone.CurrentGeneration = CurrentGeneration;
            return clone;
        }
    }
}