using System;

namespace Problem_5.MaximalIncreasingSequence
{
    public class MaximalIncreasingSequence
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] arr = new int[numbersCount];
            int counterSeq = 1;
            int maxSequence = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    counterSeq++;
                    maxSequence = (counterSeq > maxSequence) ? counterSeq : maxSequence;
                }
                else
                {
                    maxSequence = (counterSeq > maxSequence) ? counterSeq : maxSequence;
                    counterSeq = 1;
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}