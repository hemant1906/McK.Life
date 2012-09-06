namespace McK.GameOfLife.Model.Cells
{
    public abstract class AbstractCell
    {
        public int CurrentGeneration { get; private set; }


        public bool IsAlive { get; private set; }


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


        public void ShouldLive()
        {
            CurrentGeneration = CurrentGeneration + 1;
            IsAlive = true;
        }

        public void ShouldDie()
        {
            CurrentGeneration = 0; //reset generation
            IsAlive = false;
        }

        public virtual AbstractCell Clone()
        {
            var cell = (AbstractCell) MemberwiseClone();
            cell.IsAlive = IsAlive;
            cell.CurrentGeneration = CurrentGeneration;
            return cell;
        }
    }
}