using System;
using System.Collections.Generic;

namespace FindSumInArray
{
    public class FindSumInArray
    {
        public static void Main()
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int s = 11;
            int sum = 0;
            List<int> sequence = new List<int>();
            List<int> sumSequence = new List<int>();
            bool trueSum = false;

            while (trueSum == false)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i; j < array.Length; j++)
                    {
                        sum += array[j];
                        sequence.Add(array[j]);
                        if (sum == s)
                        {
                            trueSum = true;
                            sumSequence.AddRange(sequence);
                            break;
                        }
                    }

                    sum = 0;
                    sequence.Clear();
                }
            }

            if (sumSequence.Count == 0)
            {
                Console.WriteLine("A sequence cannot be found");
            }
            else
            {
                Console.WriteLine(string.Join(" ", sumSequence) + " = " + s);
            }
        }
    }
}