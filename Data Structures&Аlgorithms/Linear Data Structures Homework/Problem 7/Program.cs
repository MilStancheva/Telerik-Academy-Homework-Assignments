/*
 Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    2 → 2 times
    3 → 4 times
    4 → 3 times
 */
using System;
using System.Collections.Generic;

namespace Problem_7
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a sequence: ");
            var sequence = ReadSequnce();
            Console.WriteLine(string.Join(", ", sequence));

            var newSequence = FindNumberOfOccurancesInSequence(sequence);
            PrintOccurancesAndTheirCount(newSequence);
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

        public static Dictionary<int, int> FindNumberOfOccurancesInSequence(IList<int> sequence)
        {
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

            return numbersOfSequenceAndTheirCount;
        }

        public static void PrintOccurancesAndTheirCount(IDictionary<int, int> occurancesAndTheirCount)
        {
            foreach (var key in occurancesAndTheirCount)
            {
                if (key.Value == 1)
                {
                    Console.WriteLine($"{key.Key} -> {key.Value} time");

                }
                else
                {
                    Console.WriteLine($"{key.Key} -> {key.Value} times");
                }
            }
        }
    }
}
