/*
    Implement the ADT stack as auto-resizable array.
    Resize the capacity on demand (when no space is available to add / insert a new element).
 */
using System;

namespace Problem_12___Implement_Stack
{
    public class StartUp
    {
        public static void Main()
        {
            CustomStack<int> myFirstStack = new CustomStack<int>();

            myFirstStack.Push(5);
            myFirstStack.Push(1);
            myFirstStack.Push(6);
            myFirstStack.Push(3);
            myFirstStack.Push(13);

            Console.WriteLine("Print all items:");
            myFirstStack.PrintAllItems();

            Console.WriteLine("Poped element: {0}", myFirstStack.Pop());
            Console.WriteLine("Peeked element: {0}", myFirstStack.Peek());
        }
    }
}