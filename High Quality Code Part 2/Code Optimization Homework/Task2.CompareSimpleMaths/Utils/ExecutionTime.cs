using System;
using System.Diagnostics;

namespace Task2.CompareSimpleMaths.Utils
{
    public static class ExecutionTime
    {
        public static TimeSpan DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}
