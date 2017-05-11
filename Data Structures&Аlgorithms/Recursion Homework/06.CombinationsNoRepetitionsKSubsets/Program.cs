using System;

namespace _06.CombinationsNoRepetitionsKSubsets
{
    public class Program
    {
        const int n = 3;
        const int k = 2;
        static string[] objects = new string[n]
        {
        "test", "rock", "fun"
        };
        static int[] arr = new int[k];

        public static void Main()
        {
            GenerateCombinationsNoRepetitions(0, 0);
        }

        private static void GenerateCombinationsNoRepetitions(int index, int start)
        {
            if (index >= k)
            {
                PrintVariations();
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    arr[index] = i;
                    GenerateCombinationsNoRepetitions(index + 1, i + 1);
                }
            }
        }

        private static void PrintVariations()
        {
            Console.Write("(" + string.Join(", ", arr) + ") --> ( ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(objects[arr[i]] + " ");
            }
            Console.WriteLine(")");
        }
    }
}
