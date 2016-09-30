using System;
using Task2.CompareSimpleMaths.Contracts;

namespace Task2.CompareSimpleMaths.Utils
{
    public class ConsolePrinter : IPrinter 
    {
        public void Print(int number)
        {
            Console.WriteLine(number);
        }

        public void Print(long number)
        {
            Console.WriteLine(number);
        }

        public void Print(float number)
        {
            Console.WriteLine(number);
        }

        public void Print(double number)
        {
            Console.WriteLine(number);
        }

        public void Print(decimal number)
        {
            Console.WriteLine(number);
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Print(TimeSpan timespan)
        {
            Console.WriteLine(timespan);
        }
    }
}
