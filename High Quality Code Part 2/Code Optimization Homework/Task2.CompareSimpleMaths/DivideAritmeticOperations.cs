using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

namespace Task2.CompareSimpleMaths
{
    public class DivideAritmeticOperations
    {
        public DivideAritmeticOperations(IPrinter printer)
        {
            this.Printer = printer;
        }

        public IPrinter Printer { get; private set; }

        internal void CheckExecutionTimeWhenDivideInteger()
        {
            this.Printer.Print(string.Format("Divide integers {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                int value = 10000000;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value /= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenDivideLong()
        {
            this.Printer.Print(string.Format("Divide long {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                long value = 10000000;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value /= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenDivideFloat()
        {
            this.Printer.Print(string.Format("Divide float {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                float value = 10000000f;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value /= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenDivideDouble()
        {
            this.Printer.Print(string.Format("Divide double {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                double value = 10000000;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value /= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenDivideDecimal()
        {
            this.Printer.Print(string.Format("Divide decimal {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                decimal value = 10000000m;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value /= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }
    }
}
