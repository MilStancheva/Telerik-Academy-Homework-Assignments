using System;
using System.Collections.Generic;

namespace SortingHomework.Tests
{
    public static class CollectionsUtils
    {
        public static IList<int> GenerateCollection(int length)
        {
            IList<int> collection = new List<int>();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                collection.Add(random.Next());
            }

            return collection;
        }

        public static bool IsSorted(IList<int> collection)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                if (collection[i] > collection[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
