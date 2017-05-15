using System.Collections.Generic;

namespace _08.CheckIfPathBetweenTwoCellsExists
{
    public class PathsInMatrixFinder
    {
        private char[,] matrix;
        private List<char> path;
        private bool[,] visited;

        public PathsInMatrixFinder(char[,] matrix)
        {
            this.matrix = matrix;
            this.path = new List<char>();
            this.visited = new bool[this.matrix.GetLength(0), this.matrix.GetLength(1)];
        }

        public bool[,] Visited
        {
            get
            {
                return this.visited;
            }
        }

        private bool IsInRange(int row, int col)
        {
            bool isRowInRange = row >= 0 && row < matrix.GetLength(0);
            bool isColInRange = col >= 0 && col < matrix.GetLength(1);

            return isRowInRange && isColInRange;
        }

        public void FindPathToExit(int row, int col, char direction)
        {
            if (!this.IsInRange(row, col))
            {
                return;
            }

            this.path.Add(direction);

            if (visited[row, col])
            {
                return;
            }

            if (this.matrix[row, col] == 'e')
            {
                return;
            }

            if (matrix[row, col] == ' ')
            {
                this.visited[row, col] = true;

                matrix[row, col] = 'S';

                FindPathToExit(row, col - 1, 'L'); // left
                FindPathToExit(row - 1, col, 'U'); // up
                FindPathToExit(row, col + 1, 'R'); // right
                FindPathToExit(row + 1, col, 'D'); // down

                matrix[row, col] = ' ';
            }

            path.RemoveAt(path.Count - 1);
        }
    }
}