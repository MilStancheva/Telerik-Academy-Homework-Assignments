using System;
using System.Collections.Generic;
using System.Linq;

namespace Divisors
{
    public class Program
    {
        private static List<List<int>> allPermutations = new List<List<int>>();
        private static List<int> allNumbers = new List<int>();

        public static void Main()
        {
            int numberOfDigits = int.Parse(Console.ReadLine());
            int[] digits = new int[numberOfDigits];

            for (int i = 0; i < numberOfDigits; i++)
            {
                digits[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(digits);
            PermuteRep(digits, 0, digits.Length, perm =>
            {
                allPermutations.Add(perm.ToList());
            });

            AddNumbersPermutationsToAllNumbers();
            int numberWithMinDivisors = FindTheNumberWithTheSmallestCountOfDivisors();
            Console.WriteLine(numberWithMinDivisors);
                     
        }

        private static int FindTheNumberWithTheSmallestCountOfDivisors()
        {
            var minCountOfDivisors = int.MaxValue;
            int answer = 0;

            for (int i = 0; i < allNumbers.Count; i++)
            {
                var count = CalculateNumberOfDivisors(allNumbers[i]);
                if (count < minCountOfDivisors)
                {
                    minCountOfDivisors = count;
                    answer = allNumbers[i];
                }
            }

            return answer;
        }

        private static void AddNumbersPermutationsToAllNumbers()
        {
            for (int i = 0; i < allPermutations.Count; i++)
            {
                var number = GenerateNumber(allPermutations[i]);
                allNumbers.Add(number);
            }
        }

        private static int CalculateNumberOfDivisors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            return count;
        }

        private static void PermuteRep(int[] arr, int start, int n, Action<int[]> action)
        {
            action(arr);
            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n, action);
                    }
                }

                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[n - 1] = firstElement;
            }
        }

        private static void Swap(ref int leftElement, ref int rightElement)
        {
            int oldValue = leftElement;
            leftElement = rightElement;
            rightElement = oldValue;
        }

        private static int GenerateNumber(List<int> permutation)
        {
            int number = 0;
            string numberAsString = string.Empty;
            for (int i = 0; i < permutation.Count; i++)
            {
                numberAsString += permutation[i].ToString();
            }

            number = int.Parse(numberAsString);
            
            return number;
        }
    }
}