using System;
using System.Collections.Generic;

namespace _07.FindAllPathsBetweenTwoCellsInMatrix
{
    public class PathsInMatrixFinder
    {
        private char[,] matrix;
        private List<char> path;

        public PathsInMatrixFinder(char[,] matrix)
        {
            this.matrix = matrix;
            this.path = new List<char>();
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

            if (this.matrix[row, col] == 'e')
            {
                this.PrintPath();
            }

            if (matrix[row, col] == ' ')
            {
                matrix[row, col] = 'S';
                
                FindPathToExit(row, col - 1, 'L'); // left
                FindPathToExit(row - 1, col, 'U'); // up
                FindPathToExit(row, col + 1, 'R'); // right
                FindPathToExit(row + 1, col, 'D'); // down
                
                matrix[row, col] = ' ';
            }
            
            path.RemoveAt(path.Count - 1);
        }

        private void PrintPath()
        {
            Console.WriteLine(string.Join(", ", this.path));
        }
    }
}