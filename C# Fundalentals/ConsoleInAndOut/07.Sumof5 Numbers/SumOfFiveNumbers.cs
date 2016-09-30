using System;

namespace _07.Sumof5_Numbers
{
    public class SumOfFiveNumbers
    {
        public static void Main()
        {
            int number;
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}