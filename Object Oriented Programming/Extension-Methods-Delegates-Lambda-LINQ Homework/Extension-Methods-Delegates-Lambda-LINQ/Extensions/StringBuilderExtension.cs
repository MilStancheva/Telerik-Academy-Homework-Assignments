//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
//and has the same functionality as Substring in the class String.

namespace Extension_Methods_Delegates_Lambda_LINQ.Extensions
{
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int lenght)
        {
            var output = new StringBuilder(input.ToString(index, lenght));

            return output;
        }
    }
}
