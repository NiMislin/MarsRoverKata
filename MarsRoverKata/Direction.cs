namespace MarsRoverKata
{
    public class Direction
    {
        public static Direction GetNorth()
        {
            var north = new Direction(CardinalDirection.N);
            var south = new Direction(CardinalDirection.S);
            var east = new Direction(CardinalDirection.E);
            var west = new Direction(CardinalDirection.W);
            north.SetRight(east);
            east.SetRight(south);
            south.SetRight(west);
            west.SetRight(north);
            return north;
        }
        
        public Direction Left { get; private set; }
        public Direction Right { get; private set; }
        public CardinalDirection Cardinal { get; }

        private Direction(CardinalDirection cardinal)
        {
            Cardinal = cardinal;
        }

        private void SetLeft(Direction direction)
        {
            Left = direction;
        }

        private void SetRight(Direction direction)
        {
            Right = direction;
            direction.SetLeft(this);
        }

    }
}