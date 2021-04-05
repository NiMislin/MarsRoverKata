namespace MarsRoverKata
{
    public class MobilePosition 
        : Position
    {

        public MobilePosition(int x, int y) : base(x, y)
        {
        }

        public override Position Move(Direction direction, int[,] grid)
        {
            var newY = Y;
            var newX = X;
            switch (direction.Cardinal)
            {
                case CardinalDirection.N:
                    newY = Y + 1 > grid.GetUpperBound(0) ? 0 : Y + 1;
                    break;
                case CardinalDirection.S:
                    newY = Y - 1 < 0 ? grid.GetUpperBound(0) : Y - 1;
                    break;
                case CardinalDirection.W:
                    newX = X - 1 < 0 ? grid.GetUpperBound(1) : X - 1;
                    break;
                case CardinalDirection.E:
                    newX = X + 1 > grid.GetUpperBound(1) ? 0 : X + 1;
                    break;
            }

            if (grid[newY, newX] == 1)
            {
                return new StoppedPosition(X, Y);
            }
            
            return new MobilePosition(newX, newY);
        }
    }
}