namespace _07.FindAllPathsBetweenTwoCellsInMatrix
{
    public class StartUp
    {
        public static void Main()
        {
            var matrix = new char[,]
            {
                {' ', ' ', ' ', '*', ' ', ' ', ' '},
                {'*', '*', ' ', '*', ' ', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', '*', '*', '*', '*', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
            };
            PathsInMatrixFinder pathsFinder = new PathsInMatrixFinder(matrix);

            pathsFinder.FindPathToExit(0, 0, 'S');
        }
    }
}