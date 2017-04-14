using System.Collections;
using System.Collections.Generic;

namespace Problem_11__Implement_LinkedList
{
    public class CustomLinkedList<T> : IEnumerable<T>
    {
        private CustomLinkedListNode<T> head;
        private CustomLinkedListNode<T> tail;

        public CustomLinkedList()
        {
        }

        public int Count { get; set; }

        public CustomLinkedListNode<T> Head
        {
            get
            {
                return this.head;
            }
            set
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
            set
            {
                this.tail = value;
            }
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
    }
}