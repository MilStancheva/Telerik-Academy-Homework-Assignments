using System;
using System.Collections.Generic;

namespace Problem_1__PriorityQueueImplementation
{
    public class BinaryHeap<T>
    {
        private const int InitialCapacity = 16;

        private T[] values;
        private Comparison<T> comparisson;
        private int count;

        public BinaryHeap(Comparison<T> customComparisson)
        {
            this.values = new T[InitialCapacity];
            this.comparisson = customComparisson ?? Comparer<T>.Default.Compare;
        }

        public BinaryHeap() 
            : this(null)
        {

        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public void Insert(T item)
        {
            if (this.count == this.values.Length)
            {
                this.Resize();
            }

            this.values[this.count] = item;
            this.HeapifyUp(this.count);
            this.count++;
        }

        public T Peak()
        {
            return this.values[0];
        }

        public T Pop()
        {
            T item = this.values[0];
            this.count--;
            this.values[0] = this.values[this.count];
            this.HeapifyDown(0);
            return item;
        }

        private void Resize()
        {
            T[] resizedValues = new T[this.values.Length * 2];
            Array.Copy(this.values, 0, resizedValues, 0, this.values.Length);
            this.values = resizedValues;
        }

        private void HeapifyUp(int childIndex)
        {
            if (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (this.comparisson.Invoke(this.values[childIndex], this.values[parentIndex]) > 0)
                {
                    // swap parent and child
                    T t = this.values[parentIndex];
                    this.values[parentIndex] = this.values[childIndex];
                    this.values[childIndex] = t;
                    this.HeapifyUp(parentIndex);
                }
            }
        }

        private void HeapifyDown(int parentIndex)
        {
            int leftChildIndex = 2 * parentIndex + 1;
            int rightChildIndex = leftChildIndex + 1;
            int largestChildIndex = parentIndex;
            if (leftChildIndex < this.count && this.comparisson.Invoke(this.values[leftChildIndex], this.values[largestChildIndex]) > 0)
            {
                largestChildIndex = leftChildIndex;
            }
            if (rightChildIndex < this.count && this.comparisson.Invoke(this.values[rightChildIndex], this.values[largestChildIndex]) > 0)
            {
                largestChildIndex = rightChildIndex;
            }
            if (largestChildIndex != parentIndex)
            {
                T t = this.values[parentIndex];
                this.values[parentIndex] = this.values[largestChildIndex];
                this.values[largestChildIndex] = t;
                this.HeapifyDown(largestChildIndex);
            }
        }
    }
}