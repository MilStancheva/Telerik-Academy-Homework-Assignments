using System;
using System.Linq;

namespace Problem_4.BinarySearch
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arrayToSearch = new int[n];
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                arrayToSearch[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrayToSearch);
            int SearchResult = Array.BinarySearch(arrayToSearch, k);
           

            if (SearchResult == -1)
            {
                Console.WriteLine("No result!\n" + Environment.NewLine +
                        "{0} is the smallest element", k);
            }
            else if (SearchResult < -1)
            {
                Console.WriteLine("Largest element < {0}:" + Environment.NewLine +
                        "value: {1}, position: [{2}]",
                         k, arrayToSearch[(~SearchResult) - 1], (~SearchResult) - 1);
            }
            else
            {
                Console.WriteLine("Exact Match:" + Environment.NewLine +
                        "value: {0}, position: [{1}]", k, SearchResult);
            }
        }
    }
}
