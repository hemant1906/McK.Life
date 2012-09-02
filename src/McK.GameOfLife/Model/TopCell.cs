namespace McK.GameOfLife.Model
{
    internal class TopCell : Cell
    {
        public override bool CanHaveTopRight
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

        public override Cell Clone()
        {
            var clone = new TopCell();
            clone.IsAlive = IsAlive;
            clone.CurrentGeneration = CurrentGeneration;
            return clone;
        }
    }
}