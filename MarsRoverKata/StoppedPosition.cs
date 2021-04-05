namespace MarsRoverKata
{
    public class StoppedPosition
        : Position
    {
        public StoppedPosition(int x, int y) : base(x, y)
        {
        }

        public override Position Move(Direction direction, int[,] grid)
        {
            //do nothing
            return this;
        }

        public override string GetPosition()
        {
            return "O:" + base.GetPosition();
        }
    }
}