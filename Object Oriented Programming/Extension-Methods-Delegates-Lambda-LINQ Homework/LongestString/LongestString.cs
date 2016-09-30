//Problem 17. Longest string
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

namespace LongestString
{
    using System;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            var arrayOfStrings = new string[] 
            { "Create a class Group with properties GroupNumber and DepartmentName.",
                "Introduce a property GroupNumber in the Student class.",
                "Extract all students from \"Mathematics\" department.",
                "Use the Join operator."};

            var longestString = arrayOfStrings
                .FirstOrDefault(x => x.Length == arrayOfStrings.Max(y => y.Length));

            Console.WriteLine("{0} - Length: {1}", longestString, longestString.Length);

        }
    }
}
