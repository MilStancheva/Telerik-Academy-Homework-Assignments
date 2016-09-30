/*Float or Double
Description

Which of the following values can be assigned to a variable of type
float and which to a variable of type double:
34.567839023, 12.345, 8923.1234857, 3456.091? 
Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/

using System;

public class FloatOrDouble
{
    public static void Main()
    {
        double firstVariableOfTypeDouble = 34.567839023;
        Console.WriteLine(firstVariableOfTypeDouble);

        float firstVariableOfTypeFloat = 12.345F;
        Console.WriteLine(firstVariableOfTypeFloat);

        double secondVariableOfTypeDouble = 8923.1234857;
        Console.WriteLine(secondVariableOfTypeDouble);

        float secondVariableOfTypeFloat = 3456.091F;
        Console.WriteLine(secondVariableOfTypeFloat);
    }
}