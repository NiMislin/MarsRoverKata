namespace MarsRoverKata
{
    public class DirectionToWest
        : IDirection
    {
        public CardinalDirection Cardinal => CardinalDirection.W;
        public IDirection Left => new DirectionToSouth();
        public IDirection Right => new DirectionToNorth();
        public Position MoveForwardTo(Position initial, Grid grid) => new(grid.GetXAxisPosition(initial.X - 1), initial.Y);
    }
}