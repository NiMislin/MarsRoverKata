namespace MarsRoverKata
{
    public abstract class Position
    {
        protected int X { get; }
        protected int Y { get; }

        protected Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract Position Move(Direction direction, int[,] grid);

        public virtual string GetPosition()
        {
            return $"{Y}:{X}";
        }
    }
}