namespace McK.GameOfLife.Model
{
    public class Cell
    {
        private int _currentGeneration;

        public int CurrentGeneration
        {
            get { return _currentGeneration; }
            protected set { _currentGeneration = value; }
        }

        public bool IsAlive { get; protected set; }


        public virtual bool CanHaveTopLeft
        {
            get { return true; }
        }

        public virtual bool CanHaveTop
        {
            get { return true; }
        }

        public virtual bool CanHaveTopRight
        {
            get { return true; }
        }

        public virtual bool CanHaveBottomLeft
        {
            get { return true; }
        }

        public virtual bool CanHaveBottom
        {
            get { return true; }
        }

        public virtual bool CanHaveBottomRight
        {
            get { return true; }
        }

        public virtual bool CanHaveLeft
        {
            get { return true; }
        }

        public virtual bool CanHaveRight
        {
            get { return true; }
        }

        public virtual Cell Clone()
        {
            var cell = new Cell {IsAlive = IsAlive, CurrentGeneration = CurrentGeneration};
            return cell;
        }

        public void ShouldLive()
        {
            CurrentGeneration = CurrentGeneration + 1;
            IsAlive = true;
        }

        public void ShouldDie()
        {
            _currentGeneration = 0; //reset generation
            IsAlive = false;
        }
    }
}