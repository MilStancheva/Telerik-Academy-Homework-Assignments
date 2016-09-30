using System;

namespace _16.TrailingZeros
{
    public class TrailingZeros2
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int counterZeroes = 0;

            if (number == 5)
            {
                counterZeroes = 1;
            }
            else
            {
                for (int i = 5; number / i >= 1; i *= 5)
                {
                    counterZeroes += number / i;
                }
            }

            Console.WriteLine(counterZeroes);
        }
    }
}
