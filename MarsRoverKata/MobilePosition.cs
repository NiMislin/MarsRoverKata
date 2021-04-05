namespace MarsRoverKata
{
    public class MobilePosition 
        : Position
    {

        public MobilePosition(int x, int y) : base(x, y)
        {
        }

        public override Position Move(Direction direction, Grid grid)
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
                return new StoppedPosition(X, Y);
            }
            
            return new MobilePosition(newPosition.X, newPosition.Y);
        }
    }
}