using System;

namespace _03.Circle
{
    public class Circle
    {
        public static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * Math.Pow(r, 2);
            double circlePerimeter = 2 * Math.PI * r;

            Console.Write("{0:F2} ", circlePerimeter);
            Console.Write("{0:F2}", circleArea);
        }
    }
}