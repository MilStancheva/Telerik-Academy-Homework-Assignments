using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem_11__Implement_LinkedList
{
    public class CustomLinkedList<T> : IEnumerable<T>
    {
        private CustomLinkedListNode<T> head;
        private CustomLinkedListNode<T> tail;

        public int Count { get; set; }

        public CustomLinkedListNode<T> Head
        {
            get
            {
                return this.head;
            }
            private set
            {
                this.head = value;
            }
        }

        public CustomLinkedListNode<T> Tail
        {
            get
            {
                return this.tail;
            }
            private set
            {
                this.tail = value;
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new CustomLinkedListNode<T>()
            {
                Value = value
            };

            if (this.Head == null && this.Tail == null)
            {
                this.Head = newNode;

                this.Tail = this.Head;
            }
            else
            {
                newNode.Next = this.Head;
                this.Head = newNode;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            var newNode = new CustomLinkedListNode<T>()
            {
                Value = value
            };

            if (this.Head == null && this.Tail == null)
            {
                this.Head = newNode;

                this.Tail = this.Head;
            }
            else
            {
                this.Tail.Next = newNode;
                newNode.Previous = this.Tail;
                this.Tail = newNode;
            }

            this.Count++;
        }

        public void AddBefore(CustomLinkedListNode<T> node, T value)
        {
            var newNode = new CustomLinkedListNode<T>()
            {
                Value = value
            };

            newNode.Next = node;
            if (node.Previous != null)
            {
                node.Previous.Next = newNode;
            }
            newNode.Previous = node.Previous;
            node.Previous = newNode;

            this.Count++;
        }

        public void AddAfter(CustomLinkedListNode<T> node, T value)
        {
            var newNode = new CustomLinkedListNode<T>()
            {
                Value = value
            };

            newNode.Previous = node;
            if (node.Next != null)
            {
                node.Next.Previous = newNode;
            }
            newNode.Next = node.Next;
            node.Next = newNode;

            this.Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.Head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void PrintAllItems()
        {
            CustomLinkedListNode<T> item = this.Head;
            while (item != null)
            {
                Console.WriteLine(item.Value);
                item = item.Next;
            }
        }
    }
}