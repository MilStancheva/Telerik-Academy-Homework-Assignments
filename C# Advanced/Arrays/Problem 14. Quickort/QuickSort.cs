using System;

namespace Problem_14.Quickort
{
    public class QuickSort
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}