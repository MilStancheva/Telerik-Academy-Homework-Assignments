using System;
using System.Linq;

namespace _03.CompareCharArraysVs2
{
    public class CompareCharArrs
    {
        public static void Main()
        {
            char[] arr1 = Console.ReadLine().ToLower().ToArray();
            char[] arr2 = Console.ReadLine().ToLower().ToArray();
            int min_length = Math.Min(arr1.Length, arr2.Length);
            bool equal = true;

            for (int i = 0; i < min_length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(">");
                    equal = false;
                    break;
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("<");
                    equal = false;
                    break;
                }
            }

            if (equal && (arr1.Length == arr2.Length))
            {
                Console.WriteLine("=");
            }
            else if (equal && (arr1.Length != arr2.Length))
            {
                Console.WriteLine((arr1.Length > arr2.Length) ? ">" : "<");
            }
        }
    }
}