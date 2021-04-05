namespace MarsRoverKata
{
    public class Direction
    {
        public CardinalDirection Cardinal { get; }

        public Direction(CardinalDirection cardinal)
        {
            Cardinal = cardinal;
        }

        public Direction GetRight()
        {
            return new(Cardinal switch
            {
                CardinalDirection.N => CardinalDirection.E,
                CardinalDirection.E => CardinalDirection.S,
                CardinalDirection.S => CardinalDirection.W,
                _ =>  CardinalDirection.N
            });
        }

        public Direction GetLeft()
        {
            return new(Cardinal switch
            {
                CardinalDirection.N => CardinalDirection.W,
                CardinalDirection.W => CardinalDirection.S,
                CardinalDirection.S=> CardinalDirection.E,
                _ =>  CardinalDirection.N
            });
        }
    }
}