using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

namespace Task2.CompareSimpleMaths
{
    public class SubtractAritmeticOperations
    {
        public SubtractAritmeticOperations(IPrinter printer)
        {
            this.Printer = printer;
        }

        public IPrinter Printer { get; private set; }
        
        internal void CheckExecutionTimeWhenSubtractInteger()
        {
            this.Printer.Print(string.Format("Subtract integers {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                int result = 10000000;
                for (int i = GlobalConstants.NumberOfLoops; i >= 0; i--)
                {
                    result -= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenSubtractLong()
        {
            this.Printer.Print(string.Format("Subtract long {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                long result = 10000000;
                for (int i = GlobalConstants.NumberOfLoops; i >= 0; i--)
                {
                    result -= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenSubtractFloat()
        {
            this.Printer.Print(string.Format("Subtract float {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                float result = 10000000f;
                for (int i = GlobalConstants.NumberOfLoops; i >= 0; i--)
                {
                    result -= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenSubtractDouble()
        {
            this.Printer.Print(string.Format("Subtract double {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                double result = 10000000;
                for (int i = GlobalConstants.NumberOfLoops; i >= 0; i--)
                {
                    result -= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenSubtractDecimal()
        {
            this.Printer.Print(string.Format("Subtract decimal {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                decimal result = 10000000m;
                for (int i = GlobalConstants.NumberOfLoops; i >= 0; i--)
                {
                    result -= 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }
    }
}
