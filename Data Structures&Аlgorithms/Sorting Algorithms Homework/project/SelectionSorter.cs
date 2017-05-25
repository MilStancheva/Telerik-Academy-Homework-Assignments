using System;
using System.Collections.Generic;

namespace SortingHomework
{  
    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        private string collectionCannotBeNullExceptionMessage = "Collection cannot be null.";

        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(collectionCannotBeNullExceptionMessage);
            }

            for (int i = 0; i < collection.Count - 1; i++)
            {
                int minIndex = i;
                for (int j =  i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    this.Swap(minIndex, i, collection);
                }
            }
        }

        private void Swap(int minIndex, int i, IList<T> collection)
        {
            T temp = collection[i];
            collection[i] = collection[minIndex];
            collection[minIndex] = temp;
        }
    }
}