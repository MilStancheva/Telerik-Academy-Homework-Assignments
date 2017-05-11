using System;

namespace _04.PermutationsOfN
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter N:");
            int n = int.Parse(Console.ReadLine());

            int[] array = GenerateArray(n);
            GeneratePermutations(array, 0);
            Console.WriteLine();
        }

        private static void GeneratePermutations<T>(T[] array, int index)
        {
            if (index >= array.Length)
            {
                PrintVector(array);
            }
            else
            {
                GeneratePermutations(array, index + 1);

                for (int i = index + 1; i < array.Length; i++)
                {
                    Swap(ref array[index], ref array[i]);
                    GeneratePermutations(array, index + 1);
                    Swap(ref array[index], ref array[i]);
                }
            }
        }

        private static void Swap<T>(ref T firstElement, ref T secondElement)
        {
            T oldElement = firstElement;
            firstElement = secondElement;
            secondElement = oldElement;
        }

        private static void PrintVector<T>(T[] array)
        {
            Console.Write("{" + string.Join(" ", array) + "} ");
        }

        private static int[] GenerateArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            return array;
        }
    }
}