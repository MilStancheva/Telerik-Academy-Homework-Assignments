namespace Shapes
{
    using Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var figures = new Shape[]
            {
                new Triangle(23.45, 12.56),
                new Triangle(10.15, 24.88),
                new Triangle(5.5, 2.6),
                new Rectangle(15, 25.6),
                new Rectangle(11.33, 18.76),
                new Rectangle(16.76, 75.89),
                new Square(23.56),
                new Square(12.77),
                new Square(101.23)

            };

            foreach (var figure in figures)
            {
                Console.WriteLine("{0}: surface: {1: 0.00}", figure.GetType(), figure.CalculateSurface());
            }
        }
    }
}