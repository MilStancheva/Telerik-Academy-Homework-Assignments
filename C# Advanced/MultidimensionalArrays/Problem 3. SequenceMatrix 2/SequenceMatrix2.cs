using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.SequenceMatrix_2
{
    class SequenceMatrix2
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Console.ReadLine();

                }
                Console.WriteLine();
            }
            long currentCounter = 1;
            long maxCounter = 1;
            int bestRow = 0;
            int bestCol = 0;
            bool isVisited = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == matrix [row, col + 1])
                    {
                        currentCounter++;
                        isVisited = true;
                        if (currentCounter >= maxCounter)
                        {
                            maxCounter = currentCounter;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currentCounter++;
                        isVisited = true;
                        if (currentCounter >= maxCounter)
                        {
                            maxCounter = currentCounter;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                }
            }
            Console.WriteLine(maxCounter);
        }
    }
}

