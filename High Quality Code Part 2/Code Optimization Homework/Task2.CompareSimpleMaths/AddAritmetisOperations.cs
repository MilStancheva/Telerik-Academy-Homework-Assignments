using Task2.CompareSimpleMaths.Contracts;
using Task2.CompareSimpleMaths.Utils;

namespace Task2.CompareSimpleMaths
{
    public class AddAritmetisOperations
    {
        public AddAritmetisOperations(IPrinter printer)
        {
            this.Printer = printer;
        }

        public IPrinter Printer { get; private set; }

        internal void CheckExecutionTimeWhenAddInteger()
        {
            this.Printer.Print(string.Format("Add integers {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                int sum = 0;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    sum += 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenAddLong()
        {
            this.Printer.Print(string.Format("Add long {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                long sum = 0;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    sum += 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenAddFloat()
        {
            this.Printer.Print(string.Format("Add float {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                float sum = 0f;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    sum += 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenAddDouble()
        {
            this.Printer.Print(string.Format("Add double {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                double sum = 0;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    sum += 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }

        internal void CheckExecutionTimeWhenAddDecimal()
        {
            this.Printer.Print(string.Format("Add double {0} times takes: ", GlobalConstants.NumberOfLoops));
            var timeToExecute = ExecutionTime.DisplayExecutionTime(() =>
            {
                decimal sum = 0m;
                for (int i = 0; i < GlobalConstants.NumberOfLoops; i++)
                {
                    sum += 1;
                }
            });

            this.Printer.Print(timeToExecute);
        }
    }
}