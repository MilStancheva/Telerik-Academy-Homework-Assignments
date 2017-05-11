using System;

namespace _05.VariationsOfKElementSubsetsOfNElementSet
{
    public class Program
    {     
        public static void Main()
        {
            int n = 3;
            int k = 2;
            string[] objects = new string[]
            {
            "hi", "a", "b"
            };

            int[] numbers = new int[k];
            GenerateVariationsWithRepetitions(0, k, n, numbers, objects);
        }

        public static void GenerateVariationsWithRepetitions(int index, int k, int n, int[] numbers, string[] objects)
        {
            if (index >= k)
            {
                PrintVariations(numbers, objects);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    numbers[index] = i;
                    GenerateVariationsWithRepetitions(index + 1, k, n, numbers, objects);
                }
            }
        }

        public static void PrintVariations(int[] numbers, string[] objects)
        {
            Console.Write("(" + string.Join(", ", numbers) + ") --> ( ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(objects[numbers[i]] + " ");
            }
            Console.WriteLine(")");
        }
    }
}