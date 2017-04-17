using System;

namespace Problem_12___Implement_Stack
{
    public class CustomStack<T> : IStack<T>
    {
        private string stackIsEmptyErrorMessage = "Error. The stack is empty.";
        private int count = 0;
        private CustomStackItem<T> topElement;

        public CustomStack()
        {
            this.Count = count;
            this.topElement = null;
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

        public bool IsEmpty()
        {
            return this.topElement == null;
        }

        public T Peek()
        {
            CustomStackItem<T> item = null;

            if (!this.IsEmpty())
            {
                item = this.topElement;
            }
            else
            {
                throw new ArgumentException(stackIsEmptyErrorMessage);
            }

            return item.Value;
        }

        public T Pop()
        {
            CustomStackItem<T> item = null;

            if (!this.IsEmpty())
            {
                item = this.topElement;
                this.topElement = this.topElement.NextItem;
                this.Count--;
            }
            else
            {
                throw new ArgumentException(stackIsEmptyErrorMessage);
            }

            return item.Value;
        }

        public void Push(T item)
        {
            this.Count++;
            this.topElement = new CustomStackItem<T>()
            {
                NextItem = this.topElement,
                Value = item
            };
        }

        public void PrintAllItems()
        {
            CustomStackItem<T> item = this.topElement;
            while (item != null)
            {
                Console.WriteLine(item.Value);
                item = item.NextItem;
            }
        }
    }
}