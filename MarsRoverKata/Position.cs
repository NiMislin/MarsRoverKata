using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
    public sealed class Position
    {
        public int X { get; }
        public int Y { get; }
        
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string GetPosition()
        {
            return $"{Y}:{X}";
        }
    }
}