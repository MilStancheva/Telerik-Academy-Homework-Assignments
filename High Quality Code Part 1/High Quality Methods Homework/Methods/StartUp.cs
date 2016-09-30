using System;

namespace Methods
{
    internal class StartUp
    {
        private static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.ConvertNumberToDigitString(5));

            Console.WriteLine(Methods.FindMaxElement(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine(Methods.FindMaxElement(0, -1040, 1, 2000000000, 3, -2000000000, 3));

            Methods.PrintNumberWithPrecision(1.3);
            Methods.PrintNumberAsPercentage(0.75);
            Methods.PrintNumberAlignedRight(2.30);

            Console.WriteLine(Methods.CalculateDistanceBetweenTwoPoints(3, -1, 3, 2.5));

            bool isHorizontal = Methods.CheckIfLineIsHorizontal(-1, 2.5);
            Console.WriteLine("Horizontal? " + isHorizontal);

            bool isVertical = Methods.CheckIfLineIsVertical(3, 3);
            Console.WriteLine("Vertical? " + isVertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "From Sofia");
           
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "From Vidin, gamer, high results");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
