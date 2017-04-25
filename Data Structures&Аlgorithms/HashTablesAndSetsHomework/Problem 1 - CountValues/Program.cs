using System;
using System.Collections.Generic;

namespace Problem_1___CountValues
{
    public class Program
    {
        public static void Main()
        {
            var numbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            var occurrences = CalculateCountOfOccurrencesOfEachNumber(numbers);
            PrintDictionaryOnConsole(occurrences);
        }

        private static IDictionary<double, int> CalculateCountOfOccurrencesOfEachNumber(double[] numbers)
        {
            var occurrences = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (occurrences.ContainsKey(number))
                {
                    occurrences[number]++;
                }
                else
                {
                    occurrences[number] = 1;
                }
            }

            return occurrences;
        }

        private static void PrintDictionaryOnConsole(IDictionary<double, int> occurrences)
        {
            foreach (var number in occurrences)
            {
                if (number.Value == 1)
                {
                    Console.WriteLine($"{number.Key} -> {number.Value} time");
                }

                Console.WriteLine($"{number.Key} -> {number.Value} times");
            }
        }
    }
}