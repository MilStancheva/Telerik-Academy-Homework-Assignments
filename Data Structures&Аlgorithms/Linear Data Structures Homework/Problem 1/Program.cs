/*
    Write a program that reads from the console a sequence of positive integer numbers.
    The sequence ends when empty line is entered.
    Calculate and print the sum and average of the elements of the sequence.
    Keep the sequence in List<int>.
 */
using System;
using System.Collections.Generic;

namespace Problem_1_SumAndAverageOfSequence
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a sequence: ");
            var sequence = ReadSequnce();
            Console.WriteLine(string.Join(", ", sequence));

            var sum = CalculateSum(sequence);
            Console.WriteLine("Sum: {0}", sum);

            var average = CalculateAverage(sequence);
            Console.WriteLine("Average: {0}", average);
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

        public static int CalculateSum(List<int> sequence)
        {
            int sum = 0;

            foreach (var num in sequence)
            {
                sum += num;
            }

            return sum;
        }

        public static double CalculateAverage(List<int> sequence)
        {
            double average = (double)CalculateSum(sequence) / sequence.Count;

            return average;
        }
    }
}