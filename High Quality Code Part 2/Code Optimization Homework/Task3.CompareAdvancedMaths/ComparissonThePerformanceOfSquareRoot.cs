using System;
using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

namespace Task3.CompareAdvancedMaths
{
    public class ComparissonThePerformanceOfSquareRoot
    {
        public ComparissonThePerformanceOfSquareRoot(IPrinter printer)
        {
            this.Printer = printer;
        }

        public IPrinter Printer { get; private set; }

        internal void CheckExecutionTimeWhenCalculatingSquareRootOfAFloat()
        {
            this.Printer.Print(string.Format("Calculating the square root of type float - {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                float value = 10000000f;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value = (float)Math.Sqrt(value);
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenCalculatingSquareRootOfADouble()
        {
            this.Printer.Print(string.Format("Calculating the square root of type double - {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                double value = 10000000;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value = Math.Sqrt(value);
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenCalculatingSquareRootOfADecimal()
        {
            this.Printer.Print(string.Format("Calculating the square root of type decimal - {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                decimal value = 10000000m;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value = (decimal)Math.Sqrt((double)value);
                }
            });

            this.Printer.Print(timeToExecute);
        }
    }
}
