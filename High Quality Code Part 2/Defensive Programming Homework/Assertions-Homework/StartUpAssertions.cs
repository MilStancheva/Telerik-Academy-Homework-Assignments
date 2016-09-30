using System;

namespace Assertions_Homework
{
    public class StartUpAssertions
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            AssertionsHomework.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            try
            {
                AssertionsHomework.SelectionSort(new int[0]); // Test sorting empty array
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AssertionsHomework.SelectionSort(new int[1]); // Test sorting single element array
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(AssertionsHomework.BinarySearch(arr, -1000));
            Console.WriteLine(AssertionsHomework.BinarySearch(arr, 0));
            Console.WriteLine(AssertionsHomework.BinarySearch(arr, 17));
            Console.WriteLine(AssertionsHomework.BinarySearch(arr, 10));
            Console.WriteLine(AssertionsHomework.BinarySearch(arr, 1000));
        }
    }
}
