using System;

namespace _13.DecimalToHex
{
    public class DecimalToHex
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
                string hexaNumber = "";   // other way: string hexaNumber = null;    

                while (decimalNum > 0)
                {
                    // must be long; when this type is int the result is wrong
                    long checkRemainder = decimalNum % 16;
                    string remainder = "";
                    switch (checkRemainder)
                    {
                        case 10: remainder = "A"; break;
                        case 11: remainder = "B"; break;
                        case 12: remainder = "C"; break;
                        case 13: remainder = "D"; break;
                        case 14: remainder = "E"; break;
                        case 15: remainder = "F"; break;
                        default: remainder = checkRemainder.ToString(); break;
                    }

                    hexaNumber = remainder + hexaNumber;
                    decimalNum /= 16;
                }

                Console.WriteLine(hexaNumber);
            }
        }
    }
}