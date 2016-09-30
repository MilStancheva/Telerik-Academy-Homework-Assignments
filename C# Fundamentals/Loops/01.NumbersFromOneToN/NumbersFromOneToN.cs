using System;

namespace _01.NumbersFromOneToN
{
    public class NumbersFromOneToN
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
