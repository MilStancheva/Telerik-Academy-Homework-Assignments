/*Null Values Arithmetic
Description

Create a program that assigns null values to an integer and to a double variable.

Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

using System;

public class NullValuesArithmetic
{
    public static void Main()
    {
        int? variableOne = null;
        double? variableTwo = null;
        Console.WriteLine(variableOne);
        Console.WriteLine(variableTwo);

        variableOne = 5;
        variableTwo = 10;
        Console.WriteLine(variableOne);
        Console.WriteLine(variableTwo);
    }
}