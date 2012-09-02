namespace McK.GameOfLife.Model
{
    internal class BottomCell : Cell
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

        public override Cell Clone()
        {
            var clone = new BottomCell();
            clone.IsAlive = IsAlive;
            clone.CurrentGeneration = CurrentGeneration;
            return clone;
        }
    }
}