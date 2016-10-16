using System;

namespace Problem_2.CompareArrays
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            bool areEqual = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < n; index++)
            {

                if (arr1[index] != arr2[index])
                {
                    areEqual = false;
                    break;
                }

            }

            Console.WriteLine(areEqual ? "Equal" : "Not equal");
        }
    }
}