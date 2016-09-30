using System;

namespace _10.FibonacciNumbers
{
    public class FibonacciNumbers
    {
        public static void Main()
        {
            ulong a = 0;
            ulong b = 1;
            ulong temp = 0;

            uint n = uint.Parse(Console.ReadLine());

            if (n >= 1 && n <= 50)
            {
                Console.Write("{0}", a);

                for (int i = 1; i < n; i++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;

                    Console.Write(", {0}", a);
                }
            }
        }
    }
}
