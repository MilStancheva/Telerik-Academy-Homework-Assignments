using System;
using System.Text;

namespace RefactorMalkoKote
{
    public class StartUpMalkoKote
    {
        public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var symbol = (char)Console.Read();

            var malkoKote = DrawMalkoKote(size, symbol);
            Console.WriteLine(malkoKote);            
        }

        private static string DrawMalkoKote(int size, char symbol)
        {
            var builder = new StringBuilder();
            var counter = (size / 4) - 1;

            var patternMinus = new string(symbol, (size / 4) - 1);
            var patternPlus = new string(symbol, (size / 4) + 1);

            var space = " ";

            var earsOfMalkoKote = DrawEarsOfMalkoKote(size, symbol, space);
            builder.Append(earsOfMalkoKote);

            var headOfMalkoKote = DrawHeadOfMalkoKote(patternPlus, space, counter);
            builder.Append(headOfMalkoKote);

            var neckOfMalkoKote = DrawNeckOfMalkoKote(patternMinus, space, counter);
            builder.Append(neckOfMalkoKote);

            var upperBodyOfmalkoKote = DrawUpperBodyOfMalkoKote(patternPlus, space, counter, symbol, size);
            builder.Append(upperBodyOfmalkoKote);

            var lowerBodyOfMalkoKote = DrawLowerBodyOfMalkoKote(size, symbol, space);
            builder.Append(lowerBodyOfMalkoKote);

            var baseOfMalkoKote = DrawBaseOfMalkoKote(size, symbol, space);
            builder.AppendLine(baseOfMalkoKote);

            return builder.ToString();
        }

        private static string DrawEarsOfMalkoKote(int size, char symbol, string space)
        {
            var patternEars = string.Format("{0}{1}{0}", symbol, new string(' ', (size / 4) - 1)) + "\n";

            return space + patternEars;
        }

        private static string DrawHeadOfMalkoKote(string patternPlus, string space, int counter)
        {
            var rowOfHeadOfMalkoKote = string.Empty;
            var headOfMalkoKote = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                rowOfHeadOfMalkoKote = space + patternPlus + "\n";
            }

            headOfMalkoKote += rowOfHeadOfMalkoKote;

            return headOfMalkoKote;
        }

        private static string DrawNeckOfMalkoKote(string patternMinus, string space, int counter)
        {
            var rowOfNeckOfMalkoKote = string.Empty;
            var neckOfMalkoKote = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                rowOfNeckOfMalkoKote += space + space + patternMinus + "\n";
            }

            neckOfMalkoKote += rowOfNeckOfMalkoKote;

            return neckOfMalkoKote;
        }

        private static string DrawUpperBodyOfMalkoKote(string patternPlus, string space, int counter, char symbol, int size)
        {
            var rowOfUpperBodyOfMalkoKote = string.Empty;
            var upperBodyOfMalkoKote = string.Empty;

            for (int i = 0; i < counter + 1; i++)
            {
                if (i <= counter - 1)
                {
                    rowOfUpperBodyOfMalkoKote += space + patternPlus + "\n";
                }
                else
                {
                    rowOfUpperBodyOfMalkoKote += space + patternPlus + space + space + space + new string(symbol, size / 4) + "\n";                    
                }               
            }

            upperBodyOfMalkoKote += rowOfUpperBodyOfMalkoKote;

            return upperBodyOfMalkoKote;
        }

        private static string DrawLowerBodyOfMalkoKote(int size, char symbol, string space)
        {
            var patternPlus = new string(symbol, (size / 4) + 3);

            var rowOfLowerBodyOfMalkoKote = string.Empty;
            var lowerBodyOfMalkoKote = string.Empty;

            for (int i = 0; i < (size / 4) + 2; i++)
            {
                if (i <= size / 4)
                {
                    rowOfLowerBodyOfMalkoKote += patternPlus + space + space + symbol + "\n";
                }
                else
                {
                    rowOfLowerBodyOfMalkoKote += patternPlus + space + symbol + symbol + "\n";
                }
            }

            lowerBodyOfMalkoKote += rowOfLowerBodyOfMalkoKote;

            return lowerBodyOfMalkoKote;
        }

        private static string DrawBaseOfMalkoKote(int size, char symbol, string space)
        {
            var patternPlus = new string(symbol, (size / 4) + 4);
            var baseOfMalkoKote = space + patternPlus;

            return baseOfMalkoKote;
        }
    }
}