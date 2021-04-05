namespace MarsRoverKata
{
    public sealed class Position
    {
        private int X { get; }
        private int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Position Change(Direction direction, Grid grid)
        {
            var newPosition = (X, Y);
            
            newPosition.Y = grid.GetYAxisPosition(direction.Cardinal switch
            {
                CardinalDirection.N => Y + 1,
                CardinalDirection.S => Y - 1,
                _ => newPosition.Y
            });
            
            newPosition.X = grid.GetXAxisPosition(direction.Cardinal switch
            {
                CardinalDirection.W => X - 1,
                CardinalDirection.E => X + 1,
                _ => newPosition.X
            });

            if (grid.IsObstacle(newPosition.X, newPosition.Y))
            {
                throw new ObstacleDetectedException();
            }
            
            return new Position(newPosition.X, newPosition.Y);
        }

        public string GetPosition()
        {
            return $"{Y}:{X}";
        }
    }
}