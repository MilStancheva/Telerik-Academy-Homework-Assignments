using System;

namespace _06.BiggestOf5
{
    public class BiggestOfFive
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double biggest;

            if (a > -200 && a < 200 && b > -200 && b < 200 && c > -200 && c < 200 && d > -200 && d < 200 && e > -200 && e < 200)
            {
                if (a >= b && a >= c && a >= d && a >= e)
                {
                    biggest = a;

                    Console.WriteLine(biggest);
                }
                else if (b >= a && b >= c && b >= d && b >= e)
                {
                    biggest = b;

                    Console.WriteLine(biggest);
                }
                else if (c >= a && c >= b && c >= d && c >= e)
                {
                    biggest = c;

                    Console.WriteLine(biggest);
                }
                else if (d >= a && d >= b && d >= c && d >= e)
                {
                    biggest = d;

                    Console.WriteLine(biggest);
                }
                else if (e >= a && e >= b && e >= c && e >= d)
                {
                    biggest = e;

                    Console.WriteLine(biggest);
                }
            }
        }
    }
}