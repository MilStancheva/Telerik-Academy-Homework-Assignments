using System;

namespace Problem_6.MaximalKSum
{
    public class MaximalKSum
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            int sortedPos;
            int maxSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        sortedPos = arr[i];
                        arr[i] = arr[j];
                        arr[j] = sortedPos;
                    }
                }
            }

            for (int i = arr.Length - K; i <= arr.Length - 1; i++)
            {
                maxSum += arr[i];
            }
            Console.WriteLine(maxSum);
        }
    }
}