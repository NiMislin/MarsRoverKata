namespace MarsRoverKata
{
    public class DirectionToNorth
        : IDirection
    {
        public CardinalDirection Cardinal => CardinalDirection.N;
        public IDirection Left => new DirectionToWest();
        public IDirection Right => new DirectionToEast();
        public Position MoveForwardTo(Position initial, Grid grid) => new(initial.X, grid.GetYAxisPosition(initial.Y + 1));
    }
}