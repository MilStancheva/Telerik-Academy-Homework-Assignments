using System;
using System.Linq;

namespace Problem_5.SortByStringLength
{
    public class SortByStringLength
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Trim(' ').Split(' ').ToArray();

            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string word in array)
            {
                Console.WriteLine(word);
            }

        }
    }
}
