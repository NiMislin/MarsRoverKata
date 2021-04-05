using Xunit;

namespace MarsRoverKata.UnitTest
{
    public class MarsRoverShould
    {
        private readonly MarsRover _marsRover;

        public MarsRoverShould()
        {
            var grid = new int[10, 10];
            grid[2, 2] = 1;
            _marsRover = new MarsRover(grid);
        }
        
        [Fact]
        public void ReturnInitialPositionWhenAnyCommandIsGiven()
        {
            //arrange
            var command = string.Empty;

            //act
            var position = _marsRover.Execute(command);

            //assert
            Assert.Equal("0:0:N", position);
        }

        [Theory]
        [InlineData("R", "0:0:E")]
        [InlineData("RR", "0:0:S")]
        [InlineData("RRR", "0:0:W")]
        [InlineData("RRRR", "0:0:N")]
        public void TurnRight(string commands, string expected)
        {
            //act
            var actual = _marsRover.Execute(commands);

            //assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData("L", "0:0:W")]
        [InlineData("LL", "0:0:S")]
        [InlineData("LLL", "0:0:E")]
        [InlineData("LLLL", "0:0:N")]
        public void TurnLeft(string commands, string expected)
        {
            //act
            var actual = _marsRover.Execute(commands);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("M", "1:0:N")]
        [InlineData("RM", "0:1:E")]
        [InlineData("MRRM", "0:0:S")]
        [InlineData("RMLLM", "0:0:W")]
        [InlineData("RRM", "9:0:S")]
        [InlineData("MMMMMMMMMM", "0:0:N")]
        [InlineData("LM", "0:9:W")]
        [InlineData("RMMMMMMMMMM", "0:0:E")]
        public void Move(string commands, string expected)
        {
            //act 
            var actual = _marsRover.Execute(commands);
            
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StopWhenEncountersAnObstacle()
        {
            //Arrange
            var commands = "MMRMM";
            var expected = "O:2:1:E";
            
            //act 
            var actual = _marsRover.Execute(commands);
            
            //assert
            Assert.Equal(expected, actual);
        }
    }
}