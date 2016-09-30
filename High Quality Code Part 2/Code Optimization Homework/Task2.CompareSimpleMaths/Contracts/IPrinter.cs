using System;

namespace Task2.CompareSimpleMaths.Contracts
{
    public interface IPrinter
    {
        void Print(int number);

        void Print(long number);

        void Print(float number);

        void Print(double number);

        void Print(decimal number);

        void Print(string text);

        void Print(TimeSpan timespan);
    }
}
