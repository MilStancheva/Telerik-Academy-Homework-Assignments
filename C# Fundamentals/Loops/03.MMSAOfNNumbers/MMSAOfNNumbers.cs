using System;

namespace _03.MMSAOfNNumbers
{
    public class MMSAOfNNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            double currentNum;

            for (int i = 1; i <= n; i++)
            {
                currentNum = double.Parse(Console.ReadLine());
                sum += currentNum;

                if (currentNum < min)
                {
                    min = currentNum;
                }

                if (currentNum > max)
                {
                    max = currentNum;
                }
            }

            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", sum / n);
        }
    }
}
