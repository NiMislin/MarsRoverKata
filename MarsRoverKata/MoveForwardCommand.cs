namespace MarsRoverKata
{
    public class MoveForwardCommand
        : ICommand
    {
        private readonly MarsRover _receiver;

        public MoveForwardCommand(MarsRover receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.MoveForward();
        }
    }
}