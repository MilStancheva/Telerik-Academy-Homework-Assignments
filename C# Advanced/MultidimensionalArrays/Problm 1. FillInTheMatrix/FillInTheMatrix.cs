using System;
using System.Linq;

namespace Problem_1.FillInTheMatrix
{
    public class FillInTheMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            char letter = char.Parse(Console.ReadLine());

            switch (letter)
            {
                case 'a':
                    for (int col = 0, value = 1; col < matrix.GetLength(1); col++)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++, value++)
                        {
                            matrix[row, col] = value;
                        }
                    }

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            int element = matrix[row, col];

                            if (col == matrix.GetLength(1) - 1)
                            {
                                Console.Write("{0}", element);
                            }
                            else
                            {
                                Console.Write("{0} ", element);
                            }
                        }
                        Console.WriteLine();

                    }

                    break;

                case 'b':
                    bool down = true;

                    for (int col = 0, row = 0, value = 1; col < matrix.GetLength(1); col++)
                    {
                        while (row >= 0 && row < matrix.GetLength(0))
                        {
                            matrix[row, col] = value++;
                            row += down ? +1 : -1;
                        }
                        down = !down;
                        row += down ? +1 : -1;
                    }

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            int element = matrix[row, col];

                            if (col == matrix.GetLength(1) - 1)
                            {
                                Console.Write("{0}", element);
                            }
                            else
                            {
                                Console.Write("{0} ", element);
                            }
                        }

                        Console.WriteLine();
                    }

                    break;

                case 'c':

                    for (int row = matrix.GetLength(0) - 1, value = 1; value <= (matrix.GetLength(0) * (matrix.GetLength(1))); row--)
                    {
                        for (int currentCol = (row >= 0 ? 0 : -row), currentRow = (row >= 0 ? row : 0); currentCol < (matrix.GetLength(1) - (row >= 0 ? row : 0));)
                        {
                            matrix[currentRow++, currentCol++] = value++;
                        }
                    }

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            int element = matrix[row, col];

                            if (col == matrix.GetLength(1) - 1)
                            {
                                Console.Write("{0}", element);
                            }
                            else
                            {
                                Console.Write("{0} ", element);
                            }

                        }

                        Console.WriteLine();
                    }
                    break;

                case 'd':
                    {
                        int direction = 0;
                        int curent = 1;
                        int col = 0;
                        int row = 0;
                        do
                        {
                            matrix[col, row] = curent;
                            switch (direction % 4)
                            {
                                case 0:
                                    if ((col == n - 1) || (matrix[col + 1, row] != 0))
                                    {
                                        row++;
                                        direction++;
                                    }
                                    else
                                    {
                                        col++;
                                    }

                                    break;

                                case 1:
                                    if ((row == n - 1) || (matrix[col, row + 1] != 0))
                                    {
                                        col--;
                                        direction++;
                                    }
                                    else
                                    {
                                        row++;
                                    }

                                    break;

                                case 2:
                                    if ((col == 0) || (matrix[col - 1, row] != 0))
                                    {
                                        row--;
                                        direction++;
                                    }
                                    else
                                    {
                                        col--;
                                    }

                                    break;

                                case 3:
                                    if (matrix[col, row - 1] != 0)
                                    {
                                        col++;
                                        direction++;
                                    }
                                    else
                                    {
                                        row--;
                                    }

                                    break;
                            }

                            curent++;
                        }
                        while (curent <= n * n);

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                int element = matrix[i, j];

                                if (j == matrix.GetLength(1) - 1)
                                {
                                    Console.Write("{0}", element);
                                }
                                else
                                {

                                    Console.Write("{0} ", element);
                                }

                            }
                            Console.WriteLine();
                        }
                        break;
                    }
            }
        }
    }
}