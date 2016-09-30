using System;

namespace _01.SumOf3Numbers
{
    public class SumOf3Numbers
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a < 1000 && a > -1000 && b < 1000 && b > -1000 && c < 1000 && c > -1000)
            {
                double sum = a + b + c;

                Console.WriteLine(sum);
            }
        }
    }
}