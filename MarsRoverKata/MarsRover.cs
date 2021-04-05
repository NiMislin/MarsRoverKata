using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
    public class MarsRover
    {
        private Position _position;
        private Direction _direction;
        private bool _obstacleDetected;
        private readonly IDictionary<char, Action> _commandDictionary;
        public string CurrentPosition => $"{(_obstacleDetected?"O:":string.Empty)}{_position.GetPosition()}:{_direction.Cardinal}";

        public MarsRover(Grid grid)
        {
            _obstacleDetected = false;
            _position = new Position(0, 0);
            _direction = new Direction(CardinalDirection.N);
            _commandDictionary = new Dictionary<char, Action>()
            {
                {'M', () => _position = _position.Change(_direction, grid)},
                {'R', () => _direction = _direction.GetRight()},
                {'L', () => _direction = _direction.GetLeft()}
            };
        }

        public void Execute(string commands)
        {
            try
            {
                foreach (var command in commands)
                {
                    _commandDictionary[command]();
                }
            }
            catch (ObstacleDetectedException)
            {
                _obstacleDetected = true;
            }
        }

    }
}