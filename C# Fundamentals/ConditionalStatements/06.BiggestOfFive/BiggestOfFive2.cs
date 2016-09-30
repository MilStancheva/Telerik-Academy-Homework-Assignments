using System;

namespace _06.BiggestOfFive
{
    public class BiggestOfFive2
    {
        public static void Main()
        {
            double biggest = double.MinValue;

            for (int i = 0; i < 5; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num > biggest)
                {
                    biggest = num;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
