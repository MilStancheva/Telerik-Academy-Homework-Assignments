using System;

namespace _08.NumbersFrom_1toN
{
    public class NumbersFrom1toN
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n >= 1 && n < 1000)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
