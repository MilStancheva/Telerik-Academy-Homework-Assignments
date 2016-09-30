using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

namespace Task2.CompareSimpleMaths
{
    public class MultiplyAritmeticOperations
    {
        public MultiplyAritmeticOperations(IPrinter printer)
        {
            this.Printer = printer;
        }

        public IPrinter Printer { get; private set; }

        internal void CheckExecutionTimeWhenMultiplyInteger()
        {
            this.Printer.Print(string.Format("Multiply integers {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                int product = 1;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    product *= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenMultiplyLong()
        {
            this.Printer.Print(string.Format("Multiply long {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                long product = 1;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    product *= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenMultiplyFloat()
        {
            this.Printer.Print(string.Format("Multiply float {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                float product = 1f;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    product *= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenMultiplyDouble()
        {
            this.Printer.Print(string.Format("Multiply double {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                double product = 1;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    product *= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenMultiplyDecimal()
        {
            this.Printer.Print(string.Format("Multiply decimal {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                decimal product = 1m;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    product *= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }
    }
}
