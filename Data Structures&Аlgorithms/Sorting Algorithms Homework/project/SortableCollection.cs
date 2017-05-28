using System;
using System.Collections.Generic;

namespace SortingHomework
{ 
    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;
        private string itemCannotBeNullExceptionMessage = "Item cannot be null";

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(this.itemCannotBeNullExceptionMessage);
            }

            var result = false;

            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.Items[i].CompareTo(item) == 0)
                {
                    result =  true;
                    break;
                }
            }

            return result;
        }

        public bool BinarySearch(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(this.itemCannotBeNullExceptionMessage);
            }

            this.Sort(new QuickSorter<T>());

            int minIndex = 0;
            int maxIndex = this.Items.Count - 1;
            int middleIndex = 0;
            bool isFound = false;

            if (this.Items[minIndex].CompareTo(item) == 0)
            {
                isFound = true;
                return isFound;
            }
            else if (this.Items[maxIndex].CompareTo(item) == 0)
            {
                isFound = true;
                return isFound;
            }
            else
            {
                while (minIndex.CompareTo(maxIndex) <= 0)
                {
                    middleIndex = minIndex + (maxIndex - minIndex) / 2;

                    if (this.Items[middleIndex].CompareTo(item) == 0)
                    {
                        isFound = true;
                        return isFound;
                    }
                    else if (this.Items[middleIndex].CompareTo(item) < 0)
                    {
                        maxIndex = middleIndex - 1;
                    }
                    else
                    {
                        minIndex = middleIndex + 1;
                    }
                }
            }

            return isFound;
        }

        public void Shuffle()
        {
            Random random = new Random();

            for (int i = 0; i < this.Items.Count - 1; i++)
            {
                int randomIndex = random.Next(i + 1, this.Items.Count);
                Swap(this.Items, i, randomIndex);
            }
        }

        private void Swap(IList<T> items, int oldIndex, int newIndex)
        {
            T temp = items[oldIndex];
            items[oldIndex] = items[newIndex];
            items[newIndex] = temp;
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}