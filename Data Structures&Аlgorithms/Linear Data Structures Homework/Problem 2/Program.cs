/*
 Write a program that reads N integers from the console and reverses them using a stack.
 Use the Stack<int> class.
 */
using System;
using System.Collections.Generic;

namespace Problem_2_ReverseSequenceUsingStack
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a number N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter a sequence with N integer numbers: ");
            var sequence = GetSequnceWithNNumbers(n);
            Console.WriteLine("Sequence:");
            Console.WriteLine(string.Join(", ", sequence));

            var reversedSequence = ReverseSequence(sequence);
            Console.WriteLine("Reveresed sequence: ");
            while (reversedSequence.Count > 0)
            {
                Console.WriteLine(reversedSequence.Pop());
            }
        }

        public static IEnumerable<int> GetSequnceWithNNumbers(int n)
        {
            var input = string.Empty;
            List<int> sequence = new List<int>();

            while (sequence.Count < n)
            {
                input = Console.ReadLine();

                int number = int.Parse(input.Trim());
                sequence.Add(number);
            }

            return sequence;
        }

        public static Stack<int> ReverseSequence(IEnumerable<int> sequence)
        {
            var reversedSequence = new Stack<int>();

            foreach (var number in sequence)
            {
                reversedSequence.Push(number);
            }

            return reversedSequence;
        }
    }
}