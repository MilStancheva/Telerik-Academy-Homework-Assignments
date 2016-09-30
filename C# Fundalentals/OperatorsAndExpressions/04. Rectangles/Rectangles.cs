using System;

public class Rectangles
{
    public static void Main()
    {
        double widthRectangle = double.Parse(Console.ReadLine());
        double heightRectangle = double.Parse(Console.ReadLine());

        double areaRectangle = widthRectangle * heightRectangle;

        double perimeterRectangle = 2 * (widthRectangle + heightRectangle);

        Console.WriteLine("{0:0.00} {1:0.00}", areaRectangle, perimeterRectangle);
    }
}