using System;
using System.Collections.Generic;

namespace Minesweeper
{
    public class MinesweeperEngine
    {
        private const int MaxPointsCount = 35;
        private const int MaxHighScoreLength = 6;
        private const char MineSymbol = '*';
        private const char NoMineSymbol = '-';
        private const char UnvisitedCellSymbol = '?';

        public static void CommandExecutor()
        {
            string command = string.Empty;
            char[,] field = CreateField();
            char[,] mines = SetMines();

            bool isStartingTheGame = true;
            bool hasWonTheGame = false;
            bool hasSteppedOnAMine = false;

            do
            {
                if (isStartingTheGame)
                {
                    string welcomeMessage = "Let's play 'Minesweeper'. Try your luck to find the mineless field. /n The command 'top' will show you the rating, /n 'restart'  - a new game starts, /n 'exit' exits the game!";

                    Console.WriteLine(welcomeMessage);
                    PrintPlayField(field);
                    isStartingTheGame = false;
                }

                string setFieldsRowsAndColsMessage = "Please, type the rows and the columns of the field: ";
                Console.Write(setFieldsRowsAndColsMessage);

                string exitMessage = "Goodbuy:(";
                string invalidCommandMessage = "Error! Invalid command";

                command = Console.ReadLine().Trim();

                int row = 0;
                int column = 0;
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                List<Score> highscores = new List<Score>(MaxHighScoreLength);
                int pointsCount = 0;

                switch (command)
                {
                    case "top":
                        ShowHighScores(highscores);
                        break;
                    case "restart":
                        field = CreateField();
                        mines = SetMines();
                        PrintPlayField(field);
                        hasSteppedOnAMine = false;
                        isStartingTheGame = false;
                        break;
                    case "exit":
                        Console.WriteLine(exitMessage);
                        break;
                    case "turn":
                        if (mines[row, column] != MineSymbol)
                        {
                            if (mines[row, column] == NoMineSymbol)
                            {
                                TurnPlayer(field, mines, row, column);
                                pointsCount++;
                            }

                            if (MaxPointsCount == pointsCount)
                            {
                                hasWonTheGame = true;
                            }
                            else
                            {
                                PrintPlayField(field);
                            }
                        }
                        else
                        {
                            hasSteppedOnAMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine(invalidCommandMessage);
                        break;
                }

                string inputNameMessage = "Please, type your name: ";

                if (hasSteppedOnAMine)
                {
                    PrintPlayField(mines);

                    string lostGameMessage = string.Format("Unfortunately, you lost the game with {0} points", pointsCount);

                    Console.Write(lostGameMessage);
                    Console.WriteLine(inputNameMessage);
                    string name = Console.ReadLine();

                    Score newScore = new Score(name, pointsCount);
                    if (highscores.Count < MaxHighScoreLength - 1)
                    {
                        highscores.Add(newScore);
                    }
                    else
                    {
                        for (int i = 0; i < highscores.Count; i++)
                        {
                            if (highscores[i].Points < newScore.Points)
                            {
                                highscores.Insert(i, newScore);
                                highscores.RemoveAt(highscores.Count - 1);
                                break;
                            }
                        }
                    }

                    highscores.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    highscores.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    ShowHighScores(highscores);

                    field = CreateField();
                    mines = SetMines();
                    pointsCount = 0;
                    hasSteppedOnAMine = false;
                    isStartingTheGame = true;
                }

                if (hasWonTheGame)
                {
                    string congratulatingMessage = "Congratulations! You've successfully opened 35 cells";
                    Console.WriteLine(congratulatingMessage);
                    PrintPlayField(mines);
                    Console.WriteLine(inputNameMessage);
                    string name = Console.ReadLine();
                    Score newScore = new Score(name, pointsCount);
                    highscores.Add(newScore);
                    ShowHighScores(highscores);
                    field = CreateField();
                    mines = SetMines();
                    pointsCount = 0;
                    hasWonTheGame = false;
                    isStartingTheGame = true;
                }
            }
            while (command != "exit");
        }

        private static void ShowHighScores(List<Score> scores)
        {
            string noHighscoresMessage = "There are no highscores to be shown.";

            Console.WriteLine("Score: ");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, scores[i].Name, scores[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(noHighscoresMessage);
            }
        }

        private static void TurnPlayer(char[,] field, char[,] mines, int row, int col)
        {
            char minesCount = CountMines(mines, row, col);
            mines[row, col] = minesCount;
            field[row, col] = minesCount;
        }

        private static void PrintPlayField(char[,] field)
        {
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);
            Console.WriteLine("0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int rows = 5;
            int columns = 10;
            char[,] field = new char[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    field[i, j] = UnvisitedCellSymbol;
                }
            }

            return field;
        }

        private static char[,] SetMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] field = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    field[i, j] = NoMineSymbol;
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / columns;
                int row = mine % columns;
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                field[col, row - 1] = MineSymbol;
            }

            return field;
        }

        private static void CalculateFieldValues(char[,] field)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (field[row, col] != MineSymbol)
                    {
                        char minesCount = CountMines(field, row, col);
                        field[row, col] = minesCount;
                    }
                }
            }
        }

        private static char CountMines(char[,] field, int row, int col)
        {
            int count = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == MineSymbol)
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == MineSymbol)
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == MineSymbol)
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == MineSymbol)
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == MineSymbol)
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == MineSymbol)
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == MineSymbol)
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == MineSymbol)
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}