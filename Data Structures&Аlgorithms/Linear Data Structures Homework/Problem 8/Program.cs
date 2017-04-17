/*
    The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    Write a program to find the majorant of given array (if exists).
    Example:
    {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8_FindTheMajorantOfASequence
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a sequence: ");
            var sequence = ReadSequnce();
                        
            var majorant = FindTheMajorantOfASequence(sequence);
            Console.WriteLine("Majorant: {0}", majorant);
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

        public static string FindTheMajorantOfASequence(IList<int> sequence)
        {
            var numbersOfSequenceAndTheirCount = FindNumberOfOccurancesInSequence(sequence);
            int majorant;

            majorant = numbersOfSequenceAndTheirCount
                .Where(x => x.Value >= ((numbersOfSequenceAndTheirCount.Count / 2) + 1))
                .FirstOrDefault()
                .Value;

            return majorant > 0 ? majorant.ToString() : "No majorant exists";
        }
    }
}