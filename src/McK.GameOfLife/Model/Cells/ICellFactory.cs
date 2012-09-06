namespace McK.GameOfLife.Model.Cells
{
    internal interface ICellFactory
    {
        AbstractCell CreateCell(int row, int column);
    }
}