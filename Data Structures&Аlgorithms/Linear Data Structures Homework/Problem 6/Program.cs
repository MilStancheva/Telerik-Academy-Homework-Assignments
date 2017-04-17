/*
 Write a program that removes from given sequence all numbers that occur odd number of times.
    Example:
    {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a sequence: ");
            var sequence = ReadSequnce();
            Console.WriteLine(string.Join(", ", sequence));

            var newSequence = RemoveNumbersThatOccurOddNumberOfTimesInTheSequence(sequence);
            Console.WriteLine("New sequence:");
            Console.WriteLine(string.Join(", ", newSequence));
        }

        public static List<int> ReadSequnce()
        {
            var input = string.Empty;
            List<int> sequence = new List<int>();

            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                int number = int.Parse(input.Trim());
                sequence.Add(number);
            }

            return sequence;
        }

        public static List<int> RemoveNumbersThatOccurOddNumberOfTimesInTheSequence(IList<int> sequence)
        {
            List<int> newSequenceOfNumbersOcurringEvenNumberOfTimes = new List<int>();

            var numbersOfSequenceAndTheirCount = new Dictionary<int, int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (!numbersOfSequenceAndTheirCount.ContainsKey(sequence[i]))
                {
                    numbersOfSequenceAndTheirCount.Add(sequence[i], 1);
                }
                else
                {
                    numbersOfSequenceAndTheirCount[sequence[i]]++;
                }
            }

            newSequenceOfNumbersOcurringEvenNumberOfTimes = sequence.Where(num => numbersOfSequenceAndTheirCount[num] % 2 == 0).ToList();

            return newSequenceOfNumbersOcurringEvenNumberOfTimes;
        }
    }
}