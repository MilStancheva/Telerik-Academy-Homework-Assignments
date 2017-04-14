using System;

namespace Problem_11__Implement_LinkedList
{
    public class Program
    {
        public static void Main()
        {
            int count = 10;
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            for (int i = 0; i < count; i++)
            {
                list.AddLast(i);
            }

            var node = list.Head;
            do
            {
                Console.Write("{0} ", node.Value);
                node = node.Next;
            }
            while (node != null);
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine("Count: {0}", list.Count);
        }
    }
}