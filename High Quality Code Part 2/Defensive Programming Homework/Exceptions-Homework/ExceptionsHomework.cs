using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("arr", "The array cannot be null.");
        }

        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new IndexOutOfRangeException("Start indext must be in the range of 0 to the length of the array.");
        }

        if (count < 0)
        {
            throw new ArgumentException("Count must not be negative. The length of the subsequence should be greater than or equal to 0.");
        }

        if (startIndex + count > arr.Length)
        {
            throw new ArgumentOutOfRangeException("The sum of the symbols between the start indext and the count of the substring must be less than the length of the array.");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentNullException("str", "The input string cannot be null or empty.");
        }

        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("count", "Count should be in the range of 0 to the length of the provided string.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));

        try
        {
            ExtractEnding("Hi", 100);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        var primeNumber = 23;
        Console.WriteLine(primeNumber + " is prime: " + CheckPrime(primeNumber));
        var notPrimeNumber = 33;
        Console.WriteLine(notPrimeNumber + " is prime: " + CheckPrime(notPrimeNumber));

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };

        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
