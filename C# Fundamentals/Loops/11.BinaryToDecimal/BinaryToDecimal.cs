using System;

namespace _11.BinaryToDecimal
{
    public class BinaryToDecimal
    {
        public static void Main()
        {
            string binaryNum = Console.ReadLine();

            long decimalNum = 0;

            for (int i = 0; i < binaryNum.Length; i++)
            {
                if (binaryNum[binaryNum.Length - i - 1] == '1')
                {
                    decimalNum += (long)Math.Pow(2, i);
                }
            }

            Console.WriteLine(decimalNum);
        }
    }
}