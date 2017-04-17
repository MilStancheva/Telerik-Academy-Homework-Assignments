/*
    Implement the data structure linked list.
    Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
    Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
 */
using System;

namespace Problem_11__Implement_LinkedList
{
    public class StartUp
    {
        public static void Main()
        {
            int count = 5;
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            for (int i = 0; i < count; i++)
            {
                list.AddLast(i);
            }

            for (int i = 0; i < count; i++)
            {
                list.AddFirst(i);
            }

            list.PrintAllItems();
            Console.WriteLine("Count: {0}", list.Count);

            list.AddAfter(list.Head.Next.Next, 100);
            Console.WriteLine("After add after: ");
            list.PrintAllItems();
            Console.WriteLine("Count: {0}", list.Count);

            list.AddBefore(list.Tail.Previous, 100);
            Console.WriteLine("After add before: ");
            list.PrintAllItems();
            Console.WriteLine("Count: {0}", list.Count);
        }
    }
}