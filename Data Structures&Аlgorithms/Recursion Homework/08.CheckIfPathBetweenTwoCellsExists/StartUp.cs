using System;

namespace _08.CheckIfPathBetweenTwoCellsExists
{
    public class StartUp
    {
        public static void Main()
        {
            var nonEmptyMatrix = new char[,]
            {
                {' ', ' ', ' ', '*', ' ', ' ', ' '},
                {'*', '*', ' ', '*', ' ', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', '*', '*', '*', '*', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
            };
            PathsInMatrixFinder nonEmptyPathsFinder = new PathsInMatrixFinder(nonEmptyMatrix);

            nonEmptyPathsFinder.FindPathToExit(0, 0, 'S');
            Console.WriteLine(nonEmptyPathsFinder.Visited[2, 3]);

            var emptyMatrix = new char[100, 100];
            PathsInMatrixFinder emptyMatrixPathsFinder = new PathsInMatrixFinder(emptyMatrix);

            for (int row = 0; row < emptyMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < emptyMatrix.GetLength(1); col++)
                {
                    emptyMatrix[row, col] = ' ';
                }
            }

            emptyMatrixPathsFinder.FindPathToExit(0, 0, 'S');
            Console.WriteLine(emptyMatrixPathsFinder.Visited[99, 99]);
        }
    }
}