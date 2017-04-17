/*
    Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
 */
using System;
using System.Collections.Generic;

namespace Problem_4_LongestSubsequenceOfEqualNumbers
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a sequence: ");
            var sequence = ReadSequnce();
            Console.WriteLine(string.Join(", ", sequence));

            var longestSequenceOfEqualNumbers = FindLongestSequenceOfEqualNumbers(sequence);
            Console.WriteLine("Longest sequence of equal numbers is:");
            Console.WriteLine(string.Join(", ", longestSequenceOfEqualNumbers));
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

        public static List<int> FindLongestSequenceOfEqualNumbers(IList<int> sequence)
        {
            var longetsSequenceOfEqualNumbers = new List<int>();

            int count = 0;
            int maxCount = 0;
            int numberToAdd = sequence[0];

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    numberToAdd = sequence[i];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                longetsSequenceOfEqualNumbers.Add(numberToAdd);
            }

            return longetsSequenceOfEqualNumbers;
        }
    }
}