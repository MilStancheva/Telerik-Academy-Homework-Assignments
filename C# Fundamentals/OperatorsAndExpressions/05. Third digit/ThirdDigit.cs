using System;

public class ThirdDigit
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int dividedByOneHundred = number / 100;
        int digit = dividedByOneHundred % 10;

        if (number > 0 && digit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", digit);
        }
    }
}