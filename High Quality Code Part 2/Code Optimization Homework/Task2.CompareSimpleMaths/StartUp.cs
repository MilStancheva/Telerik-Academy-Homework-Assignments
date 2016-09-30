using System;
using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

/*Write a program to compare the performance of:
add, subtract, increment, multiply, divide
for the values:
int, long, float, double and decimal
*/

namespace Task2.CompareSimpleMaths
{
    public class StartUp
    {
        public static void Main()
        {
            IPrinter printer = new ConsolePrinter();
            AddAritmetisOperations addMathOperations = new AddAritmetisOperations(printer);
            SubtractAritmeticOperations subtractMathOperations = new SubtractAritmeticOperations(printer);
            IncrementAritmeticOperations incrementMathOperations = new IncrementAritmeticOperations(printer);
            MultiplyAritmeticOperations multiplyMathOperations = new MultiplyAritmeticOperations(printer);
            DivideAritmeticOperations divideMathOperations = new DivideAritmeticOperations(printer);

            printer.Print("Checking the execution time when adding numbers:");
            addMathOperations.CheckExecutionTimeWhenAddInteger();
            addMathOperations.CheckExecutionTimeWhenAddLong();
            addMathOperations.CheckExecutionTimeWhenAddFloat();
            addMathOperations.CheckExecutionTimeWhenAddDouble();
            addMathOperations.CheckExecutionTimeWhenAddDecimal();
            printer.Print(Environment.NewLine);

            printer.Print("Checking the execution time when subtracting numbers:");
            subtractMathOperations.CheckExecutionTimeWhenSubtractInteger();
            subtractMathOperations.CheckExecutionTimeWhenSubtractLong();
            subtractMathOperations.CheckExecutionTimeWhenSubtractFloat();
            subtractMathOperations.CheckExecutionTimeWhenSubtractDouble();
            subtractMathOperations.CheckExecutionTimeWhenSubtractDecimal();
            printer.Print(Environment.NewLine);

            printer.Print("Checking the execution time when incrementing numbers:");
            incrementMathOperations.CheckExecutionTimeWhenIncrementInteger();
            incrementMathOperations.CheckExecutionTimeWhenIncrementLong();
            incrementMathOperations.CheckExecutionTimeWhenIncrementFloat();
            incrementMathOperations.CheckExecutionTimeWhenIncrementDouble();
            incrementMathOperations.CheckExecutionTimeWhenIncremenDecimal();
            printer.Print(Environment.NewLine);

            printer.Print("Checking the execution time when multiplying numbers:");
            multiplyMathOperations.CheckExecutionTimeWhenMultiplyInteger();
            multiplyMathOperations.CheckExecutionTimeWhenMultiplyLong();
            multiplyMathOperations.CheckExecutionTimeWhenMultiplyFloat();
            multiplyMathOperations.CheckExecutionTimeWhenMultiplyDouble();
            multiplyMathOperations.CheckExecutionTimeWhenMultiplyDecimal();
            printer.Print(Environment.NewLine);

            printer.Print("Checking the execution time when dividing numbers:");
            divideMathOperations.CheckExecutionTimeWhenDivideInteger();
            divideMathOperations.CheckExecutionTimeWhenDivideLong();
            divideMathOperations.CheckExecutionTimeWhenDivideFloat();
            divideMathOperations.CheckExecutionTimeWhenDivideDouble();
            divideMathOperations.CheckExecutionTimeWhenDivideDecimal();
            printer.Print(Environment.NewLine);
        }
    }
}
