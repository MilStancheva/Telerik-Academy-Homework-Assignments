using System;
using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

namespace Task3.CompareAdvancedMaths
{
    public class ComparissonOfThePerformanceOfSinus
    {
        public ComparissonOfThePerformanceOfSinus(IPrinter printer)
        {
            this.Printer = printer;
        }

        public IPrinter Printer { get; private set; }

        internal void CheckExecutionTimeWhenCalculatingSinusOfFloats()
        {
            this.Printer.Print(string.Format("Calculating the sinus of type float - {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                float value = 10000000f;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value = (float)Math.Sin(value);
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenCalculatingSinusOfDouble()
        {
            this.Printer.Print(string.Format("Calculating the sinus of type double - {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                double value = 10000000;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value = Math.Sin(value);
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenCalculatingSinusOfDecimal()
        {
            this.Printer.Print(string.Format("Calculating the sinus of type decimal - {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                decimal value = 10000000m;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value = (decimal)Math.Sin((double)value);
                }
            });

            this.Printer.Print(timeToExecute);
        }
    }
}
