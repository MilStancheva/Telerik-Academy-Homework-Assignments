using System;

namespace _05.NumbersComparer
{
    public class NumbersComparer
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}", a > b ? a : b);
        }
    }
}
