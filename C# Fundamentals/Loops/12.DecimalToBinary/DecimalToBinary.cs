using System;

namespace _12.DecimalToBinary
{
    public class DecimalToBinary
    {
        public static void Main()
        {
            long decimalNum = long.Parse(Console.ReadLine());

            if (decimalNum == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                string binaryNum = "";

                while (decimalNum > 0)
                {
                    int remaider = (int)decimalNum % 2;
                    binaryNum = remaider + binaryNum;
                    decimalNum /= 2;
                }

                Console.WriteLine(binaryNum);
            }
        }
    }
}