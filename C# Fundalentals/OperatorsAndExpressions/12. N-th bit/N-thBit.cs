using System;

public class NthBit
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        if (position >= 0 && position < 55 && 0 <= number)
        {
            long mask = 1 << position;
            long numberAndMask = number & mask;
            long bit = numberAndMask >> position;

            Console.WriteLine(bit);
        }
    }
}