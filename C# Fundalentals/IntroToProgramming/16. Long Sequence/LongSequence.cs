using System;

namespace IntroToProgramming
{
    public class LongSequence
    {
        public static void Main()
        {
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * (-1));
                }
            }
        }
    }
}