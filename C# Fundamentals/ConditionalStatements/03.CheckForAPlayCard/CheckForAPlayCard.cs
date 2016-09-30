using System;

namespace _03.CheckForAPlayCard
{
    public class CheckForAPlayCard
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            if (input.Length <= 5 && input.Length >= 1)
            {
                switch (input)
                {
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "A":
                        Console.WriteLine("yes {0}", input);
                        break;
                    default:
                        Console.WriteLine("no {0}", input);
                        break;
                }
            }
        }
    }
}
