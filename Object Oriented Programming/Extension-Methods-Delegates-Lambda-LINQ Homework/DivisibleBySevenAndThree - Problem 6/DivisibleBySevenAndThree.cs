//Problem 6. Divisible by 7 and 3
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions.Rewrite the same with LINQ.

namespace DivisibleBySevenAndThree
{
    using System;
    using System.Linq;

    class DivisibleBySevenAndThree
    {
        static void Main()
        {
            Console.WriteLine(string.Join(", ", new int[] { 4, 19, 21, 144, 48, 84, 96, 12, 7, 100, 0, 13, -5, 12, 3, 7 }
                .Where(x => ((x % 7) == 0) && ((x % 3) == 0))
                .ToArray()));
        }
    }
}
