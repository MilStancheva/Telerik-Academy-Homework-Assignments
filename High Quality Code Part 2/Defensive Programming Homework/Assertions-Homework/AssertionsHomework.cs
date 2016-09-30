using System;
using System.Diagnostics;

namespace Assertions_Homework
{
    public class AssertionsHomework
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("array", "The array should exist and should not be null");
            }

            if (arr.Length < 2)
            {
                throw new ArgumentException("The array should have more than 2 elements.");
            }

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }             

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("array", "The array cannot be null or empty.");
            }

            if (value == null)
            {
                throw new ArgumentNullException("value", "The value cannot be null");
            }

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null && arr.Length > 1 && startIndex <= endIndex, "Array should not be null or empty and the start index should be less or equal to the end index.");
            Debug.Assert(value != null, "Search value should not be null.");
            Debug.Assert(startIndex >= 0, "The start index should be greater or equal to zero.");
            Debug.Assert(startIndex < arr.Length, "The start index should be less than the length of the array.");
            Debug.Assert(endIndex >= 0, "The end index should be greater or equal to zero.");
            Debug.Assert(endIndex < arr.Length, "The end index should be less than the length of the array.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null && arr.Length > 1 && startIndex <= endIndex, "Array should not ne null or empty and the start index should be less or equal to the end index.");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}