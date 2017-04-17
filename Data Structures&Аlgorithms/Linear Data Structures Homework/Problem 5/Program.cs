/*
    Write a program that removes from given sequence all negative numbers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a sequence: ");
            var sequence = ReadSequnce();
            Console.WriteLine(string.Join(", ", sequence));

            var positiveSequence = RemoveAllNegativeNumbersFromSequence(sequence);
            Console.WriteLine("Positive sequence:");
            Console.WriteLine(string.Join(", ", positiveSequence));
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

        public static List<int> RemoveAllNegativeNumbersFromSequence(IList<int> sequence)
        {
            var positiveSequence = sequence.Where(x => x >= 0).ToList();

            return positiveSequence;
        }
    }
}