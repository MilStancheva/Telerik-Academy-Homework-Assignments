/*
    Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
 */
using System;
using System.Collections.Generic;

namespace Problem_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a sequence: ");
            var sequence = ReadSequnce();
            Console.WriteLine(string.Join(", ", sequence));

            var sortedSequence = SortSequenceInIncreasingOrder(sequence);
            Console.WriteLine("Sorted sequence in increasing order: ");
            Console.WriteLine(string.Join(", ", sortedSequence));
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

        public static IEnumerable<int> SortSequenceInIncreasingOrder(List<int> sequence)
        {
            sequence.Sort();

            return sequence;
        }
    }
}