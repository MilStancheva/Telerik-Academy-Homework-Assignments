using System;
using System.Numerics;

namespace _07.Calculate3
{
    public class Calculate3
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger nkFactorial = 1;
            BigInteger result = 0;

            for (int i = 1; i < n + 1; i++)
            {
                nFactorial *= i;

                if (i <= k)
                {
                    kFactorial *= i;
                }
            }

            for (int nk = n - k; nk > 1; nk--)
            {
                nkFactorial *= nk;
            }

            result = (nFactorial / (kFactorial * nkFactorial));
            Console.WriteLine(result);
        }
    }
}
