using System;

namespace _17.Spiral_Matrix
{
    public class SpiralMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int currentRow = 0;
            int currentCol = 0;
            string direction = "right";

            for (int i = 0; i < n * n; i++)
            {
                switch (direction)
                {
                    case "right":
                        if (currentCol == n || matrix[currentRow, currentCol] != 0)
                        {
                            direction = "down";
                            currentCol--;
                            currentRow++;
                            if (i < n * n - 1)
                            {
                                i--;
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = i + 1;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                            currentCol++;
                        }

                        break;

                    case "down":
                        if (currentRow == n || matrix[currentRow, currentCol] != 0)
                        {
                            direction = "left";
                            currentCol--;
                            currentRow--;
                            if (i < n * n - 1)
                            {
                                i--;
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = i + 1;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                            currentRow++;
                        }
                        break;

                    case "left":
                        if (currentCol < 0 || matrix[currentRow, currentCol] != 0)
                        {
                            direction = "up";
                            currentRow--;
                            currentCol++;
                            if (i < n * n - 1)
                            {
                                i--;
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = i + 1;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                            currentCol--;
                        }
                        break;

                    case "up":
                        if (currentRow < 1 || matrix[currentRow, currentCol] != 0)
                        {
                            direction = "right";
                            currentCol++;
                            currentRow++;
                            if (i < n * n - 1)
                            {
                                i--;
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = i + 1;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                            currentRow--;
                        }
                        break;

                    default:
                        break;
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col].ToString() + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
