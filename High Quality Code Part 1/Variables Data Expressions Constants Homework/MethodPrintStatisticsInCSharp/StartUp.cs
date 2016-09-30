using System;
using System.Linq;

namespace MethodPrintStatisticsInCSharp
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var sequence = new double[] { 1, 3, 10, 20 };
            PrintStatistics(sequence);       
        }

        /// <summary>
        /// PrintStatistics receives a sequence of double type and prints on the console its minimum, maximum and average values.
        /// </summary>
        /// <param name="arr">a double type array</param>
        public static void PrintStatistics(double[] arr)
        {
            double maxNumber = arr.Max();
            PrintMaxNumber(maxNumber);

            double minNumebr = arr.Min();
            PrintMinNumber(minNumebr);

            double averageNumber = arr.Average();
            PrintAverageValue(averageNumber);
        }

        private static void PrintMaxNumber(double maxNumber)
        {
            Console.WriteLine("The biggest number is: " + maxNumber);
        }

        private static void PrintMinNumber(double minNumber)
        {
            Console.WriteLine("The smallest number is: " + minNumber);
        }
        
        private static void PrintAverageValue(double averageNumber)
        {
            Console.WriteLine("The average number is: " + averageNumber);
        }
    }
}
