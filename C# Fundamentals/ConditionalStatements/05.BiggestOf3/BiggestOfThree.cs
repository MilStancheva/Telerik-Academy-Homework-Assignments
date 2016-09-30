using System;

namespace _05.BiggestOf3
{
    public class BiggestOfThree
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double biggest;

            if (a > -200 && a < 200 && b > -200 && b < 200 && c > -200 && c < 200)
            {
                if (a >= b && a >= c)
                {
                    biggest = a;

                    Console.WriteLine(biggest);
                }
                else if (b >= a && b >= c)
                {
                    biggest = b;

                    Console.WriteLine(biggest);
                }
                else if (c >= a && c >= b)
                {
                    biggest = c;

                    Console.WriteLine(biggest);
                }
            }
        }
    }
}
