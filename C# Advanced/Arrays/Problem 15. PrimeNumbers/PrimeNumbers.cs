using System;

namespace Problem_15.PrimeNumbers
{
    public class PrimeNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var isPrime = new byte[n + 1];
            var lastPrime = 0;

            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i] == 0)
                {
                    lastPrime = i;
                    for (int j = i * 2; j <= n; j += i)
                    {
                        isPrime[j] = 1;
                    }
                }
            }

            Console.WriteLine(lastPrime);
        }
    }
}