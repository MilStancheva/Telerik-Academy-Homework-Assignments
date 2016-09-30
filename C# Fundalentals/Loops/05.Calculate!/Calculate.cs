using System;

namespace _05.Calculate_
{
    public class Calculate
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            long factorial = 1;
            double sum = 1 + 1 / x;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
                double pow = Math.Pow(x, i);
                sum += (factorial / pow);
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
