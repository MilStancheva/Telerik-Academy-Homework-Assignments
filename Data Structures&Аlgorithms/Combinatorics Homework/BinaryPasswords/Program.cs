using System;

namespace BinaryPasswords
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            long countOfPossiblePasswords = CalculateCountOfPossiblePasswords(input);
            Console.WriteLine(countOfPossiblePasswords);
        }

        private static int FindTheCountOfMissingSymbols(string input)
        {
            int countOfMissingSymbols = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    countOfMissingSymbols++;
                }
            }

            return countOfMissingSymbols;
        }

        public static long CalculateCountOfPossiblePasswords(string input)
        {
            long countOfPossiblePasswords = 1;
            long numberOfPossibleSymbols = 2;
            int countOfMissingSymbols = FindTheCountOfMissingSymbols(input);

            for (int i = 0; i < countOfMissingSymbols; i++)
            {
                countOfPossiblePasswords *= numberOfPossibleSymbols;
            }

            return countOfPossiblePasswords;
        }
    }
}