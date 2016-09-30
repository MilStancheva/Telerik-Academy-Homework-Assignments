using System;

public class Trapezoids
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) * h) / 2;
        Console.WriteLine("{0:0.0000000}", area);
    }
}