using System;

namespace ClassSizeInCSharp
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Figure newFigure = new Figure(5, 3);
            var rotatedFigure = Figure.GetRotatedFigure(newFigure, 3.2);
            Console.WriteLine(rotatedFigure.ToString());
        }
    }
}
