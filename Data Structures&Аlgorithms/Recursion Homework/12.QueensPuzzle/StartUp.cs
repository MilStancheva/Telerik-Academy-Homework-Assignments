using System;

namespace _12.QueensPuzzle
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter the size of the board:");
            int boardSize = int.Parse(Console.ReadLine());

            QueenPuzzleSolver solver = new QueenPuzzleSolver(boardSize);
            int result = solver.FindAllSolutions();
            Console.WriteLine($"Solution: {result}");
        }
    }
}