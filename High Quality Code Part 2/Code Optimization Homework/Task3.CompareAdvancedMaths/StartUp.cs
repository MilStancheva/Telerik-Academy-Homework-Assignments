using System;
using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

namespace Task3.CompareAdvancedMaths
{
    public class StartUp
    {
        public static void Main()
        {
            IPrinter printer = new ConsolePrinter();
            ComparissonThePerformanceOfSquareRoot compareThePerformanceOfSqrt = new ComparissonThePerformanceOfSquareRoot(printer);
            ComparissonOfThePerformanceOfNaturalLogarithm compareTheNaturalLogarithm = new ComparissonOfThePerformanceOfNaturalLogarithm(printer);
            ComparissonOfThePerformanceOfSinus compareTheSinus = new ComparissonOfThePerformanceOfSinus(printer);

            printer.Print("Checking the execution time when calculating square root:");
            compareThePerformanceOfSqrt.CheckExecutionTimeWhenCalculatingSquareRootOfAFloat();
            compareThePerformanceOfSqrt.CheckExecutionTimeWhenCalculatingSquareRootOfADouble();
            compareThePerformanceOfSqrt.CheckExecutionTimeWhenCalculatingSquareRootOfADecimal();
            printer.Print(Environment.NewLine);

            printer.Print("Checking the execution time when calculating natural logarithm:");
            compareTheNaturalLogarithm.CheckExecutionTimeWhenCalculatingNaturalLogarithmOfFloats();
            compareTheNaturalLogarithm.CheckExecutionTimeWhenCalculatingNaturalLogarithmOfDouble();
            compareTheNaturalLogarithm.CheckExecutionTimeWhenCalculatingNaturalLogarithmOfDecimal();
            printer.Print(Environment.NewLine);

            printer.Print("Checking the execution time when calculating sinus:");
            compareTheSinus.CheckExecutionTimeWhenCalculatingSinusOfFloats();
            compareTheSinus.CheckExecutionTimeWhenCalculatingSinusOfDouble();
            compareTheSinus.CheckExecutionTimeWhenCalculatingSinusOfDecimal();
            printer.Print(Environment.NewLine);
        }
    }
}
