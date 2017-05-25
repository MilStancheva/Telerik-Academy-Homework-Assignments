using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SortingHomework
{
    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        private string collectionCannotBeNullExeptionMessage = "Collection cannot be null";

        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(collectionCannotBeNullExeptionMessage);
            }

            IList<T> sortedCollection = this.QuickSort(collection, true);
            collection.Clear();
            foreach (T item in sortedCollection)
            {
                collection.Add(item);
            }
        }

        private IList<T> QuickSort(IList<T> collection, bool isAsync = false)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            int pivotIndex = collection.Count / 2;
            T pivot = collection[pivotIndex];
            var left = new List<T>();
            var right = new List<T>();

            for (int i = 0; i < pivotIndex; i++)
            {
                if (collection[i].CompareTo(pivot) < 0)
                {
                    left.Add(collection[i]);
                }
                else
                {
                    right.Add(collection[i]);
                }
            }

            for (int i = pivotIndex + 1; i < collection.Count; i++)
            {
                if (collection[i].CompareTo(pivot) < 0)
                {
                    left.Add(collection[i]);
                }
                else
                {
                    right.Add(collection[i]);
                }
            }

            IList<T> sortedLeft = null;
            IList<T> sortedRight = null;

            if (isAsync)
            {
                Task leftTask = Task.Run(() => sortedLeft = QuickSort(left));
                Task rightTask = Task.Run(() => sortedRight = QuickSort(right));
                Task.WaitAll(leftTask, rightTask);
            }
            else
            {
                sortedLeft = QuickSort(left);
                sortedRight = QuickSort(right);
            }

            List<T> result = new List<T>();

            result.AddRange(sortedLeft);
            result.Add(pivot);
            result.AddRange(sortedRight);

            return result;
        }
    }
}