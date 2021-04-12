namespace MarsRoverKata
{
    public class DirectionToSouth
        : IDirection
    {
        public CardinalDirection Cardinal => CardinalDirection.S; 
        public IDirection Left => new DirectionToEast();
        public IDirection Right => new DirectionToWest();
        public Position MoveForwardTo(Position initial, Grid grid) => new(initial.X, grid.GetYAxisPosition(initial.Y - 1));
    }
}