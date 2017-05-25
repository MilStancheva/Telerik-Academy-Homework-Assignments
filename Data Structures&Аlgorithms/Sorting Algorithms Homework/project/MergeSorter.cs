using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingHomework
{
    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        private string collectionCannotBeNullExceptionMessage = "Collection cannot be null";
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(collectionCannotBeNullExceptionMessage);
            }

            var sortedCollection = this.MergeSort(collection, true);
            collection.Clear();
            foreach (var item in sortedCollection)
            {
                collection.Add(item);
            }
        }

        private IList<T> MergeSort(IList<T> collection, bool isAsync = false)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            int midIndex = collection.Count / 2;
            var left = collection.Take(midIndex).ToList();
            var right = collection.Skip(midIndex).ToList();

            if (isAsync)
            {
                Task leftTask = Task.Run(() => left = MergeSort(left).ToList());
                Task rightTask = Task.Run(() => right = MergeSort(right).ToList());
                Task.WaitAll(leftTask, rightTask);
            }
            else
            {
                left = MergeSort(left).ToList();
                right = MergeSort(right).ToList();
            }

            return this.Merge(left, right);
        }

        private IList<T> Merge(IList<T> left, IList<T> right)
        {
            var mergedResult = new List<T>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    mergedResult.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    mergedResult.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < left.Count)
            {
                mergedResult.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                mergedResult.Add(right[rightIndex]);
                rightIndex++;
            }

            return mergedResult;
        }
    }
}