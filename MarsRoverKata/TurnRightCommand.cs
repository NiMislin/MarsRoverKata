namespace MarsRoverKata
{
    public class TurnRightCommand
        : ICommand
    {
        private readonly MarsRover _receiver;

        public TurnRightCommand(MarsRover receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.TurnRight();
        }
    }
}