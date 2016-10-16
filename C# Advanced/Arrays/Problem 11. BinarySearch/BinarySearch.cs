using System;
using System.Linq;

namespace Problem_11.BinarySearch
{
    public class BinarySearch
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int X = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            bool isInArray = true;

            if (arr.Contains(X))
            {
                isInArray = true;
                int index = Array.BinarySearch(arr, X);
                Console.WriteLine(index);

            }
            else
            {
                isInArray = false;
                Console.WriteLine(-1);
            }
        }
    }
}