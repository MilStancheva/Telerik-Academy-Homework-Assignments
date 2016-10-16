using System;

namespace Problem_8.MaximalSum
{
    public class MaximalSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;
            double maxSum = double.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                if (sum < 0)
                {
                    sum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
