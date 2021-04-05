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
            _position = new Position(0, 0);
            _direction = Direction.GetNorth();
            _commandDictionary = new Dictionary<char, Action>()
            {
                {'M', () => _position = _position.Change(_direction, grid)},
                {'R', () => _direction = _direction.Right},
                {'L', () => _direction = _direction.Left}
            };
        }

        public void Execute(string commands)
        {
            try
            {
                _obstacleDetected = false;
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