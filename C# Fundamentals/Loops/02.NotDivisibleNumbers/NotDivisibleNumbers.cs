using System;

namespace _02.NotDivisibleNumbers
{
    public class NotDivisibleNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string line = "1";

            if (number > 0 && number < 1500)
            {
                for (int i = 2; i <= number; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        line += " " + i;
                    }
                }
            }

            Console.Write(line);
        }
    }
}
