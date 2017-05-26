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
                throw new ArgumentNullException(itemCannotBeNullExceptionMessage);
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
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
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