using System;

namespace _09.IntDoubleAndString
{
    public class IntDoubleAndString
    {
        public static void Main()
        {
            string typeOfInput = Console.ReadLine();

            switch (typeOfInput)
            {
                case "integer":
                    int input = int.Parse(Console.ReadLine());
                    input += 1;
                    Console.WriteLine(input);
                    break;
                case "real":
                    double realInput = double.Parse(Console.ReadLine());
                    realInput += 1;
                    Console.WriteLine("{0:F2}", realInput);
                    break;
                case "text":
                    string textInput = Console.ReadLine();
                    Console.WriteLine(textInput + "*");
                    break;
                default:
                    break;
            }
        }
    }
}
