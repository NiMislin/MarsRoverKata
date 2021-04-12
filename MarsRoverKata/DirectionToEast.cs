namespace MarsRoverKata
{
    public class DirectionToEast
        : IDirection
    {
        public CardinalDirection Cardinal => CardinalDirection.E;
        public IDirection Left => new DirectionToNorth();
        public IDirection Right => new DirectionToSouth();
        public Position MoveForwardTo(Position initial, Grid grid) => new(grid.GetXAxisPosition(initial.X + 1), initial.Y);
    }
}