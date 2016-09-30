using System;

public class PointInACircle
{
    public static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 2.0;

        double distanceFromCenter = Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2));

        if (x > -1000 && x < 1000 && y > -1000 && y < 1000 && ((x * x) + (y * y)) <= (radius * radius))
        {
            Console.WriteLine("yes {0:0.00}", distanceFromCenter);
        }
        else
        {
            Console.WriteLine("no {0:0.00}", distanceFromCenter);
        }
    }
}