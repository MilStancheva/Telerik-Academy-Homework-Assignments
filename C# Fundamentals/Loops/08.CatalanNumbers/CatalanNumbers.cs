using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    public class CatalanNumbers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result;

            result = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));

            Console.WriteLine(result);
        }

        public static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
