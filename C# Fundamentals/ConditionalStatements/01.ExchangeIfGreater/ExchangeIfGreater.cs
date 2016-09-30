using System;

namespace _01.ExchangeIfGreater
{
    public class ExchangeIfGreater
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double biggerNum;

            if (secondNumber > -100 && secondNumber < 100 && secondNumber > -100 && secondNumber < 100)
            {
                if (firstNumber > secondNumber)
                {
                    biggerNum = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = biggerNum;
                }

                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
        }
    }
}
