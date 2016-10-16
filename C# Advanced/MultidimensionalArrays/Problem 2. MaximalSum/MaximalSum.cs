using System;
using System.Linq;

namespace Problem_2.MaximalSum
{
    public class MaximalSum
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int N = numbers[0];
            int M = numbers[1];

            var rectangular = new int[N][];

            for (int i = 0; i < N; i++)
            {
                rectangular[i] = new int[M];
            }

            for (int i = 0; i < N; i++)
            {
                input = null;
                input = Console.ReadLine();
                rectangular[i] = input.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            }

            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row  = 0; row  < N - 2; row ++)
            {
                for (int col = 0; col < M - 2; col++)
                {
                    long sum = rectangular[row][col] + rectangular[row + 1][col + 1] + rectangular[row + 2][col + 2] +
                                rectangular[row][col + 1] + rectangular[row][col + 2] + rectangular[row + 1][col] +
                                rectangular[row + 1][col + 2] + rectangular[row + 2][col] + rectangular[row + 2][col+1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
