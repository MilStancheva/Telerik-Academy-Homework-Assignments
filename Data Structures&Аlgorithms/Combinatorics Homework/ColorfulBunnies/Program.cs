using System;

namespace ColorfulBunnies
{
    public class Program
    {
        public static void Main()
        {
            int countOfAskedBunnies = int.Parse(Console.ReadLine());
            int[] replies = new int[countOfAskedBunnies];
            for (int i = 0; i < countOfAskedBunnies; i++)
            {
                replies[i] = int.Parse(Console.ReadLine());
            }

            int minNumberOfBunniesInTown = GetMinimumNumberOfBunniesInTown(replies);
            Console.WriteLine(minNumberOfBunniesInTown);
        }

        private static int GetMinimumNumberOfBunniesInTown(int[] replies)
        {
            int maxCountOfPossibleAnswers = 1000002;
            int[] cache = new int[maxCountOfPossibleAnswers];
            for (int i = 0; i < replies.Length; i++)
            {
                cache[replies[i] + 1]++;
            }

            int minNumberOfBunniesInTown = 0;
            for (int i = 0; i < cache.Length; i++)
            {
                if (cache[i] == 0)
                {
                    continue;
                }

                if (cache[i] <= i)
                {
                    minNumberOfBunniesInTown += i;
                }
                else
                {
                    minNumberOfBunniesInTown += (int) Math.Ceiling((double) cache[i] / i) * i;
                }
            }

            return minNumberOfBunniesInTown;
        }
    }
}