using System;

namespace _01.nNestedLoops
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter the size of the nested loops N:");
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            GenerateNNestedLoops(0, numbers);
        }

        private static void GenerateNNestedLoops(int index, int[] vector)
        {
            if (index == vector.Length)
            {
                PrintVector(vector);
                return;
            }

            for (int i = 1; i <= vector.Length; i++)
            {
                vector[index] = i;
                GenerateNNestedLoops(index + 1, vector);
            }
        }

        private static void PrintVector(int[] vector)
        {
            Console.Write(string.Join(" ", vector));
            Console.WriteLine();
        }
    }
}