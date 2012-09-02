namespace McK.GameOfLife.Model
{
    internal class BottomLeftCell : Cell
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

        public override Cell Clone()
        {
            var clone = new BottomLeftCell();
            clone.IsAlive = IsAlive;
            clone.CurrentGeneration = CurrentGeneration;
            return clone;
        }
    }
}