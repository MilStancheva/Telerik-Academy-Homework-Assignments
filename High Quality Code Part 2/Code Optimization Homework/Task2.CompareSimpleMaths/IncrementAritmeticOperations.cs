using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

namespace Task2.CompareSimpleMaths
{
    public class IncrementAritmeticOperations
    {
        public IncrementAritmeticOperations(IPrinter printer)
        {
            this.Printer = printer;
        }

        public IPrinter Printer { get; private set; }

        internal void CheckExecutionTimeWhenIncrementInteger()
        {
            this.Printer.Print(string.Format("Increment integers {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                int value = 0;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value++;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenIncrementLong()
        {
            this.Printer.Print(string.Format("Increment long {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                long value = 0;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value++;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenIncrementFloat()
        {
            this.Printer.Print(string.Format("Increment float {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                float value = 0f;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value++;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenIncrementDouble()
        {
            this.Printer.Print(string.Format("Increment double {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                double value = 0;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value++;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenIncremenDecimal()
        {
            this.Printer.Print(string.Format("Increment decimal {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                decimal value = 0m;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    value++;
                }
            });

            this.Printer.Print(timeToExecute);
        }
    }
}
