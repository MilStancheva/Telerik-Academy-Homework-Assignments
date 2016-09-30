using System;

namespace Methods
{
    public static class Methods
    {
        internal static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            bool arePositiveSides = (0 < sideA) && (0 < sideB) && (0 < sideC);

            if (!arePositiveSides)
            {
                throw new ArgumentOutOfRangeException("The sides of the triangle should be non negative!");
            }

            bool isSumOfTwoSidesBiggerThanTheThirdOne = sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB;

            if (!isSumOfTwoSidesBiggerThanTheThirdOne)
            {
                throw new ArgumentOutOfRangeException("The sum of two of the sides of the triangle should be bigger than its third side!");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * 
                                        (halfPerimeter - sideA) * 
                                        (halfPerimeter - sideB) * 
                                        (halfPerimeter - sideC));

            return area;
        }

        internal static string ConvertNumberToDigitString(int number)
        {
            if (number < 0 || number > 9)
            {
                throw new ArgumentOutOfRangeException("Number should be in the range of 0 to 9 includingly");
            }

            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Invalid number!";
            }
        }

        internal static int FindMaxElement(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Input array should not be null or empty");
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] < int.MinValue)
                {
                    throw new ArgumentOutOfRangeException("The array contains values smaller than the minimum integer type value.");
                }

                if (elements[i] > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("The array contains values bigger than the maximum integer type value.");
                }
            }

            int currentMaxElement = int.MinValue;
            int maxElement = int.MinValue;

            for (int i = 1; i < elements.Length; i++)
            {
                int currentElement = elements[i];

                if (currentElement > elements[0])
                {
                    currentMaxElement = currentElement;
                }

                if (currentMaxElement > maxElement)
                {
                    maxElement = currentMaxElement;
                }
            }
            
            return maxElement;
        }

        internal static void PrintNumberWithPrecision(double number)
        {
            var result = string.Format("{0:f2}", number);

            Console.WriteLine(result);
        }

        internal static void PrintNumberAsPercentage(double number)
        {
            var result = string.Format("{0:p0}", number);         

            Console.WriteLine(result);
        }

        internal static void PrintNumberAlignedRight(double number)
        {
            var result = string.Format("{0,8}", number);
            
            Console.WriteLine(result);
        }

        internal static double CalculateDistanceBetweenTwoPoints(
                                                    double firstPointX,
                                                    double firstPointY, 
                                                    double secondPointX, 
                                                    double secondPointY)
        {
            double distance = Math.Sqrt(
                                    ((secondPointX - firstPointX) * 
                                    (secondPointX - firstPointX)) + 
                                    ((secondPointY - firstPointY) * 
                                    (secondPointY - firstPointY)));

            return distance;
        }

        internal static bool CheckIfLineIsHorizontal(double firstPointY, double secondPointY)
        {
            bool isHorizontal = firstPointY == secondPointY;

            return isHorizontal;
        }

        internal static bool CheckIfLineIsVertical(double firstPointX, double secondPointX)
        {
            bool isVertical = firstPointX == secondPointX;

            return isVertical;
        }        
    }
}
