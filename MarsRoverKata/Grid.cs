namespace MarsRoverKata
{
    public class Grid
    {
        private const int XAxis = 1;
        private const int YAxis = 0;
        private readonly int[,] _grid;
        
        public Grid(int yUpperBound, int xUpperBound)
        {
            _grid = new int[yUpperBound, xUpperBound];
        }

        public bool IsObstacle(int x, int y)
        {
            return _grid[y, x] == 1;
        }

        public int GetXAxisPosition(int position)
        {
            return GetAxisPosition(position, XAxis);
        }

        public int GetYAxisPosition(int position)
        {
            return GetAxisPosition(position, YAxis);
        }
        
        private int GetAxisPosition(int position, int axis)
        {
            var newPosition = position;
            if (position < 0)
            {
                newPosition = _grid.GetUpperBound(axis);
            }
            else if (position > _grid.GetUpperBound(axis))
            {
                newPosition = 0;
            }

            return newPosition;
        }

        public void AddObstacle(int x, int y)
        {
            _grid[y, x] = 1;
        }
    }
}