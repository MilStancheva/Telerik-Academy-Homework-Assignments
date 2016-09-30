using System;
using System.Numerics;

namespace _10.OddAndEvenProduct
{
    public class OddAndEvenProduct
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            BigInteger oddProduct = 1;
            BigInteger evenProduct = 1;

            for (int i = 0; i < n; i += 2)
            {
                oddProduct *= int.Parse(splitNumbers[i]);
            }

            for (int i = 1; i < n; i += 2)
            {
                evenProduct *= int.Parse(splitNumbers[i]);
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }
    }
}
