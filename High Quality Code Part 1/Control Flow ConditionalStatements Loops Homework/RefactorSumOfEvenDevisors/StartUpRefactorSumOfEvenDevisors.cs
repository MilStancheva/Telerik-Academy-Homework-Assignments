using System;

namespace RefactorSumOfEvenDevisors
{
    public class StartUpRefactorSumOfEvenDevisors
    {
        public static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            var totalSumOfEvenDivisors = CalculateSumOfEvenDivisors(startNumber, endNumber);
            Console.WriteLine(totalSumOfEvenDivisors);
        }

        private static int CalculateSumOfEvenDivisors(int startNumber, int endNumber)
        {
            int divisor = 0;
            int sumOfEvenDividorsInNumber = 0;

            int totalSumEvenDividers = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = 1; j <= endNumber; j++)
                {
                    if (i % j == 0)
                    {
                        if (j % 2 == 0)
                        {
                            divisor = j;
                            sumOfEvenDividorsInNumber += divisor;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            totalSumEvenDividers += sumOfEvenDividorsInNumber;

            return totalSumEvenDividers;
        }
    }
}
