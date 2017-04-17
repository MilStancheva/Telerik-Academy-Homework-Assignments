using System;
using System.Collections.Generic;

namespace Problem_13___Implement_Queue
{
    public class LinkedQueue<T> : IQueue<T>
    {
        private const string QueueIsEmptyExceptionMessage = "The queue is empty.";
        private LinkedList<T> elements;

        public LinkedQueue()
        {
            this.elements = new LinkedList<T>();
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        public void Clear()
        {
            this.elements.Clear();
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException(QueueIsEmptyExceptionMessage);
            }

            T value = this.elements.First.Value;
            this.elements.RemoveFirst();

            return value;
        }

        public void Enqueue(T value)
        {
            this.elements.AddLast(value);
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException(QueueIsEmptyExceptionMessage);
            }

            return this.elements.First.Value;
        }

        public void PrintAllItems()
        {
            LinkedListNode<T> item = this.elements.First;
            while (item != null)
            {
                Console.WriteLine(item.Value);
                item = item.Next;
            }
        }
    }
}