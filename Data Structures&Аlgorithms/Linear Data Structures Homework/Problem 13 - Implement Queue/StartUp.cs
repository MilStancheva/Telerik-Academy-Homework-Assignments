/*
    Implement the ADT queue as dynamic linked list.
    Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
 */
using System;

namespace Problem_13___Implement_Queue
{
    public class StartUp
    {
        public static void Main()
        {
            LinkedQueue<int> myFirstQueue = new LinkedQueue<int>();

            myFirstQueue.Enqueue(3);
            myFirstQueue.Enqueue(5);
            myFirstQueue.Enqueue(7);
            myFirstQueue.Enqueue(12);
            myFirstQueue.Enqueue(32);

            myFirstQueue.PrintAllItems();
            Console.WriteLine($"Count of queue's elements before dequeue: {myFirstQueue.Count}");
            Console.WriteLine($"Dequeue and the first element is: {myFirstQueue.Dequeue()}");
            Console.WriteLine($"Count of queue's elements after dequeue: {myFirstQueue.Count}");
            myFirstQueue.Clear();
            Console.WriteLine($"Count of queue's elements after clear: {myFirstQueue.Count}");
        }
    }
}