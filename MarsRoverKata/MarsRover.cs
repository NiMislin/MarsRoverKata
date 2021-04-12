using System.Collections.Generic;

namespace MarsRoverKata
{
    public class MarsRover
    {
        private readonly Grid _grid;
        private Position _position;
        private IDirection _direction;
        private readonly IDictionary<char, ICommand> _commandDictionary;
        
        public string CurrentPosition =>
            $"{(_direction is NoMove ? "O:" : string.Empty)}{_position.GetPosition()}:{_direction.Cardinal}";

        public MarsRover(Grid grid)
        {
            _grid = grid;
            _position = new Position(0, 0);
            _direction = new DirectionToNorth();
            _commandDictionary = new Dictionary<char, ICommand>()
            {
                {'M', new MoveForwardCommand(this)},
                {'R', new TurnRightCommand(this)},
                {'L', new TurnLeftCommand(this)}
            };

        }

        public void Execute(string commands)
        {
            foreach (var command in commands)
            {
                _commandDictionary[command].Execute();
            }
        }

        public void TurnRight()
        {
            _direction = _direction.Right;
        }

        public void TurnLeft()
        {
            _direction = _direction.Left;
        }

        public void MoveForward()
        {
            var newPosition = _direction.MoveForwardTo(_position, _grid);
            if (_grid.IsObstacle(newPosition.X, newPosition.Y))
            {
                _direction = new NoMove(_direction.Cardinal);
                return;
            }

            _position = newPosition;
        }
    }
}