using System;

namespace Problem_7.SelectionSort
{
    public class SelectionSort
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            int sortedNum;

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
                        sortedNum = arr[i];
                        arr[i] = arr[j];
                        arr[j] = sortedNum;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}