using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RefactorMessages
{
    public class StartUpMessages
    {
        public static void Main(string[] args)
        {
            List<string> digitsInGeorge = new List<string> { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

            string firstNumber = Console.ReadLine();
            string operationSymbol = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            BigInteger firstDecimalNum = GetDecimalNumber(firstNumber, digitsInGeorge);
            BigInteger secondDecimalNum = GetDecimalNumber(secondNumber, digitsInGeorge);

            var decimalResult = CalculateDecimalResult(operationSymbol, firstDecimalNum, secondDecimalNum);
            
            Console.WriteLine(ConvertDecimalToGeorgeNumSystem(decimalResult, digitsInGeorge));
        }

        private static BigInteger CalculateDecimalResult(string operationSymbol, BigInteger firstDecimalNumber, BigInteger secondDecimalNumber)
        {
            BigInteger decimalResult = 0;

            if (operationSymbol == "-")
            {
                decimalResult = firstDecimalNumber - secondDecimalNumber;
            }
            else
            {
                decimalResult = firstDecimalNumber + secondDecimalNumber;
            }

            return decimalResult;
        }

        private static StringBuilder ConvertDecimalToGeorgeNumSystem(BigInteger decimalResult, List<string> digitsInGeorge)
        {
            StringBuilder result = new StringBuilder();

            do
            {
                int digitInGeorge = (int)(decimalResult % 10);
                result.Insert(0, digitsInGeorge[digitInGeorge]);
                decimalResult /= 10;
            }
            while (decimalResult > 0);

            return result;
        }

        private static BigInteger GetDecimalNumber(string number, List<string> digitsInGeorge)
        {
            BigInteger decimalNumber = 0;

            for (int i = 0; i < number.Length; i += 3)
            {
                string digit = number.Substring(i, 3);
                var decimalDigit = digitsInGeorge.IndexOf(digit);
                decimalNumber *= 10;
                decimalNumber += decimalDigit;
            }

            return decimalNumber;
        }
    }
}