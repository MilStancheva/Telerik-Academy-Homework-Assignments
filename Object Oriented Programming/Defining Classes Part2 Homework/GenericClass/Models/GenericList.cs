//Problem 5. Generic class
//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for 
//- adding element, 
//- accessing element by index, 
//- removing element by index, 
//- inserting element at given position, 
//- clearing the list, 
//- finding element by its value and 
//- ToString().

namespace GenericClass.Models
{
    using System;

    public class GenericList<T> where T : IComparable<T>
    {
        //Fields
        private T[] data;

        private int lastPosition = 0;
        
        //Constructor
        public GenericList(int initialCapacity)
        {
            this.data = new T[initialCapacity];
        }

        //Methods
        public void AddElement(T element)
        {
            if (this.lastPosition == this.data.Length)
            {
                //throw new IndexOutOfRangeException(); 
                this.AutoGrow();
            }
            this.data[lastPosition] = element;
            this.lastPosition++;
        }

        public T this[int index]
        {
            get
            {
                if (index > lastPosition - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.data[index];
            }
            private set { this.data[index] = value; }
        }

        public void RemoveByIndex(int index)
        {
            for (int i = index; i < this.lastPosition && i < this.data.Length - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.lastPosition--;
            this.data[lastPosition] = default(T);
        }

        public void InsertAtGivenPosition(int index, T element)
        {
            if (this.lastPosition == this.data.Length)
            {
                //throw new IndexOutOfRangeException(); 
                this.AutoGrow();
            }
            for (int i = this.lastPosition; i >= index && i > 0; i--)
            {
                this.data[i] = this.data[i -1];
            }
            this.data[index] = element;
            this.lastPosition++;
        }

        public void Clear()
        {
            this.data = new T[this.data.Length];
        }

        public T Min() 
        {
            //return this.data.Min();
            if (this.lastPosition == 0)
            {
                throw new ArgumentException("There are no elements in the Generic list");
            }
            T min = this.data[0];
            foreach (T item in this.data)
            {
                if (min.CompareTo(item) > 0 )
                {
                    min = item;
                }
            }
            return min;
        }

        public T Max()
        {
            // return this.data.Max();

            if (this.lastPosition == 0)
            {
                throw new ArgumentException("There are no elements in the Generic list");
            }
            T max = this.data[0];
            foreach (T item in this.data)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public override string ToString()
        {
            return string.Join(", ", this.data);
        }

        //Problem 6. Auto-grow
        //Implement auto-grow functionality: when the internal array is full, 
        //create a new array of double size and move all elements to it.

        private void AutoGrow()
        {
            var newData = new T[this.data.Length * 2];
            for (int i = 0; i <this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData;
        }
    }

}
