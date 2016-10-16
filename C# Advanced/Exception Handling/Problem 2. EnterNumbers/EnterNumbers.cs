using System;
using System.Collections.Generic;
using System.Linq;

namespace EnterNumbers
{
    public class EnterNumbers
    {
        public static void Main()
        {
            List<int> numbersList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbersList.Add(int.Parse(Console.ReadLine()));
            }

            int start = 0;
            int end = 100;

            PrintIfSorted(start, end, numbersList);
        }

        private static void PrintIfSorted(int start, int end, IList<int> numbersList)
        {
            string argumentExceptionMessage = "The list of numbers must be sorted and in the range of [start; end]";
            try
            {
                if (!IsSorted(numbersList) || numbersList.Any(x => x < start) || numbersList.Any(x => x > end))
                {
                    throw new ArgumentException(argumentExceptionMessage);
                }

                string result = string.Format("1 < " + string.Join(" < ", numbersList) + " < 100");
                Console.WriteLine(result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static bool IsSorted<T>(IList<T> numbers)
            where T : IComparable
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1].CompareTo(numbers[i]) != -1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}