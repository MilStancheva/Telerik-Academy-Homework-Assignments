using System;

namespace _09.SumOfNNumbers
{
    public class SumOfNNumbers
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double number;
            double sum = 0;

            if (n >= 0 && n <= 200)
            {
                for (int i = 1; i <= n; i++)
                {
                    number = double.Parse(Console.ReadLine());
                    sum += number;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
