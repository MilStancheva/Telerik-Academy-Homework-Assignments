using System;

namespace _03.CombinationsWithoutDuplicates
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter the number of elements K: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the number of element set N: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[k];
            GenerateCombinationsWithoutDuplicates(0, vector, n);
            Console.WriteLine();
        }

        private static void GenerateCombinationsWithoutDuplicates(int index, int[] vector, int n)
        {
            if (index == vector.Length)
            {
                PrintVector(vector);
                return;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    vector[index] = i;
                    if (index > 0 && vector[index] <= vector[index - 1])
                    {
                        continue;
                    }

                    GenerateCombinationsWithoutDuplicates(index + 1, vector, n);
                }
            }            
        }

        private static void PrintVector(int[] vector)
        {
            Console.Write("(" + string.Join(" ", vector) + ") ");
        }
    }
}