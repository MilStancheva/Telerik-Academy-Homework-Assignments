using System;

namespace RefactorMutantSquirrels
{
    public class StartUpMutantSquirrels
    {
        public static void Main(string[] args)
        {
            long numberOfTreesInTheForest = long.Parse(Console.ReadLine());
            long numberOfBranchesOnATree = long.Parse(Console.ReadLine());
            long numberOfSquirrelsOnABranch = long.Parse(Console.ReadLine());
            long averageNumberOfTailsOfASquirrel = long.Parse(Console.ReadLine());

            double totalNumberOfSquirrelTails = CalculateTotalNumberOfSquirrelTails(
                                                                                    numberOfTreesInTheForest,
                                                                                    numberOfBranchesOnATree,
                                                                                    numberOfSquirrelsOnABranch,
                                                                                    averageNumberOfTailsOfASquirrel);

            double result = CalculateFinalResult(totalNumberOfSquirrelTails);

            Console.WriteLine("{0:F3}", result);
        }

        private static double CalculateTotalNumberOfSquirrelTails(long numberOfTreesInForest, long numberOfBranchesOnATree, long numberOfSquirrelsOnABranch, long averageNumberOfTailsOfASquirrel)
        {
            double totalNumberOfSquirrelTails = numberOfTreesInForest *
                                                numberOfBranchesOnATree *
                                                numberOfSquirrelsOnABranch *
                                                averageNumberOfTailsOfASquirrel;

            return totalNumberOfSquirrelTails;
        }

        private static double CalculateFinalResult(double totalNumberOfSquirrelTails)
        {
            double result = 1;
            int magicNumbetToMultiply = 376439;
            double magicNumberToDevide = 7.0;

            if (totalNumberOfSquirrelTails % 2 == 0)
            {
                result = totalNumberOfSquirrelTails * magicNumbetToMultiply;
            }
            else
            {
                result = totalNumberOfSquirrelTails / magicNumberToDevide;
            }

            return result;
        }
    }
}