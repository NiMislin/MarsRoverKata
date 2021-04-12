using System.Reflection.Metadata;

namespace MarsRoverKata
{
    public interface IDirection
    {
        public CardinalDirection Cardinal { get; }
        public IDirection Left { get;  }
        public IDirection Right { get; }
        Position MoveForwardTo(Position initial, Grid grid);
    }
}