using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
    public class MarsRover
    {
        private Position _position;
        private Direction _direction;
        private readonly IDictionary<char, Action> _commandDictionary;

        public MarsRover(int[,] grid)
        {
            _position = new MobilePosition(0, 0);
            _direction = new Direction(CardinalDirection.N);
            _commandDictionary = new Dictionary<char, Action>()
            {
                {'M', () => _position = _position.Move(_direction, grid)},
                {'R', () => _direction = _direction.GetRight()},
                {'L', () => _direction = _direction.GetLeft()}
            };
        }

        public string Execute(string commands)
        {
            foreach (var command in commands)
            {
                _commandDictionary[command]();
            }

            return $"{_position.GetPosition()}:{_direction.Cardinal}";
        }
    }
}