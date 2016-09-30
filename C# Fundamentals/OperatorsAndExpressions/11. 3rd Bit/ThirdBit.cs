using System;

public class ThirdBit
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int position = 3;

        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;

        Console.WriteLine(bit);
    }
}