using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SequenceOfColorfulBalls
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int numberOfElements = input.Length;
            IDictionary<char, int> numberOfDifferentLetters = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!numberOfDifferentLetters.ContainsKey(input[i]))
                {
                    numberOfDifferentLetters.Add(input[i], 1);
                }
                else
                {
                    numberOfDifferentLetters[input[i]]++;
                }
            }

            BigInteger divisor = 1;
            for (int i = 0; i < numberOfDifferentLetters.Count; i++)
            {
                var currentGroup = numberOfDifferentLetters.ElementAt(i).Value;
                var factorial = Factorial(currentGroup);
                divisor = divisor * factorial;
            }

            BigInteger numberOfPermutations = Factorial(numberOfElements) / divisor;
            Console.WriteLine(numberOfPermutations);            
        }

        public static BigInteger Factorial(long n)
        {
            var result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}