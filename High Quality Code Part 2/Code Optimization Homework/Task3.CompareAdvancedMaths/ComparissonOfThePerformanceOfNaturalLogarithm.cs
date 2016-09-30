using System;
using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

namespace Task3.CompareAdvancedMaths
{
    public class ComparissonOfThePerformanceOfNaturalLogarithm
    {
        public ComparissonOfThePerformanceOfNaturalLogarithm(IPrinter printer)
        {
            this.Printer = printer;
        }

        public IPrinter Printer { get; private set; }

        internal void CheckExecutionTimeWhenCalculatingNaturalLogarithmOfFloats()
        {
            this.Printer.Print(string.Format("Calculating the natural logarithm of type float - {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                float value = 10000000f;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value = (float)Math.Log(value, Math.E);
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenCalculatingNaturalLogarithmOfDouble()
        {
            this.Printer.Print(string.Format("Calculating the natural logarithm of type double - {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                double value = 10000000;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value = Math.Log(value, Math.E);
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenCalculatingNaturalLogarithmOfDecimal()
        {
            this.Printer.Print(string.Format("Calculating the natural logarithm of type decimal - {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                try
                {
                    decimal value = 10000000m;
                    for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                    {
                        value = (decimal)Math.Log((double)value, Math.E);
                    }
                }
                catch (OverflowException ex)
                {
                    this.Printer.Print(ex.Message);
                }
            });

            this.Printer.Print(timeToExecute);
        }
    }
}
