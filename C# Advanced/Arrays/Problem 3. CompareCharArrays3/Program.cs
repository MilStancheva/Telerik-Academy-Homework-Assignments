using System;

namespace Problem_3.CompareCharArraysVs3
{
    public class Program
    {
        public static void Main()
        {
            string text1 = Console.ReadLine();
            char[] arr1;
            arr1 = text1.ToCharArray();

            string text2 = Console.ReadLine();
            char[] arr2;
            arr2 = text2.ToCharArray();

            if (string.Compare(text1, text2) < 0)
            {
                Console.WriteLine("<");
            }
            else if (string.Compare(text1, text2) > 0)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}