using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    public class QuadraticEquation
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double x1;
            double x2;

            double delta = ((b * b) - (4 * a * c));

            if (a > -1000 && a < 1000 && b > -1000 && b < 1000 && c > -1000 && c < 1000)
            {
                if (delta < 0)
                {
                    Console.WriteLine("no real roots");
                }
                else if (delta == 0)
                {
                    x1 = ((-b) / (2 * a));
                    x2 = x1;

                    Console.WriteLine("{0:F2}", x1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

                    if (x1 < x2)
                    {
                        Console.WriteLine("{0:F2}", x1);
                        Console.WriteLine("{0:F2}", x2);
                    }
                    else if (x2 < x1)
                    {
                        Console.WriteLine("{0:F2}", x2);
                        Console.WriteLine("{0:F2}", x1);
                    }
                }
            }
        }
    }
}
