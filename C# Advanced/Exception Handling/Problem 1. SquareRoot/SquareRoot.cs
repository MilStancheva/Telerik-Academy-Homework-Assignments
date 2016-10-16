using System;

namespace Problem_1.SquareRoot
{
    public class SquareRoot
    {
        public static void Main()
        {
            string farewellGreeting = "Good bye";
            string exceptionMessage = "Invalid number";
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException(exceptionMessage);
                }
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("{0:F3}", squareRoot);

            }
            
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine(farewellGreeting);
            }
        }
    }
}
