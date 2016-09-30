/*Comparing Floats
Description

Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.

Note: Two floating-point numbers a and b cannot be compared directly by a == b because of 
the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more 
closely to each other than a fixed constant eps.

Input

On the first line you will receive the first floating-point number
On the second line you will receive the second floating-point number
Hint: Use double.Parse(Console.ReadLine()) to read input

Output

Print true if the numbers are equal or false if they are not*/

using System;

public class CompraringFloats
{
    public static void Main()
    {
        double firstVariable = double.Parse(Console.ReadLine());
        double secondVariable = double.Parse(Console.ReadLine());

        bool isEqual = Math.Abs(firstVariable - secondVariable) < 0.000001;

        if (isEqual)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}