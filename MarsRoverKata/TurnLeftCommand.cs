namespace MarsRoverKata
{
    public class TurnLeftCommand
        : ICommand
    {
        private readonly MarsRover _receiver;

        public TurnLeftCommand(MarsRover receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.TurnLeft();
        }
    }
}