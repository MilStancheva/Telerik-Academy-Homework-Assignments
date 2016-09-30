using System;
using System.Numerics;

namespace _16.Trailing_0_in_N_
{
    public class TrailingZero
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            while (number > 0)
            {
                factorial *= number;
                number--;
            }

            int counterZeroes = 0;

            while (factorial % 10 == 0)
            {
                counterZeroes++;
                factorial /= 10;
            }

            Console.WriteLine(counterZeroes);
        }
    }
}