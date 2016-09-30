using System;

namespace _15.GCD
{
    public class GCD
    {
        public static void Main()
        {
            string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int firstNum = int.Parse(splitNumbers[0]);
            int secondNum = int.Parse(splitNumbers[1]);

            int numBigger = Math.Abs(firstNum);
            int numSmaller = Math.Abs(secondNum);

            if (numSmaller > numBigger)
            {
                numSmaller += numBigger;
                numBigger = numSmaller - numBigger;
                numSmaller = numSmaller - numBigger;
            }

            int remainder = numBigger % numSmaller;

            while (remainder != 0)
            {
                numBigger = numSmaller;
                numSmaller = remainder;
                remainder = numBigger % numSmaller;
            }

            int gcd = numSmaller;

            Console.WriteLine(gcd);
        }
    }
}
