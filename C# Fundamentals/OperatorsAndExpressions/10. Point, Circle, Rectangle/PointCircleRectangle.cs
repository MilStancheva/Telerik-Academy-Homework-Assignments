using System;

public class PointCircleRectangle
{
    public static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double circleCenterX = 1;
        double circlecenterY = 1;
        double radius = 1.5;

        double topRectangle = 1;
        double leftRectangle = -1;
        double widthRectangle = 6;
        double heigthRectangle = 2;

        if (x < 1000 && x > -1000 && y < 1000 && y > -1000)
        {
            bool isInCircle = (x - circleCenterX) * (x - circleCenterX) + (y - circlecenterY) * (y - circlecenterY) <= (radius * radius);
            bool isInRectangle = (x >= leftRectangle) && (x <= (leftRectangle + widthRectangle)) && (y >= (topRectangle - heigthRectangle)) && (y <= topRectangle);

            Console.Write(isInCircle ? "inside circle " : "outside circle ");
            Console.WriteLine(isInRectangle ? "inside rectangle" : "outside rectangle");
        }
    }
}