using System;
using System.Collections.Generic;

public class RemoveElementsFromArray
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        AddNumbersToList(n, numbers);
        int[] size = new int[numbers.Count];

        for (int i = 0; i < numbers.Count; i++)
        {
            size[i] = 1;
        }

        int max = 1;
        for (int i = 1; i < numbers.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] >= numbers[j] && size[i] <= size[j] + 1)
                {
                    size[i] = size[j] + 1;
                    if (max < size[i])
                    {
                        max = size[i];
                    }
                }
            }
        }

        int numbersToRemove = n - max;
        Console.WriteLine(numbersToRemove);
    }

    private static void AddNumbersToList(int n, List<int> numbers)
    {
        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers.Add(currentNumber);
        }
    }
}