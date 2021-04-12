namespace MarsRoverKata
{
    public class NoMove
        : IDirection
    {
        public CardinalDirection Cardinal { get; } 
        public IDirection Left => this;
        public IDirection Right => this;

        public NoMove(CardinalDirection cardinal)
        {
            Cardinal = cardinal;
        }

        public Position MoveForwardTo(Position initial, Grid grid)
        {
            return initial;
        }
    }
}