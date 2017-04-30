using System;

namespace Problem_1__PriorityQueueImplementation
{
    public class StartUp
    {
        public static void Main()
        {
            BinaryHeap<int> maxPriorityQueue = new BinaryHeap<int>();
            maxPriorityQueue.Insert(4);
            maxPriorityQueue.Insert(1);
            maxPriorityQueue.Insert(2);
            maxPriorityQueue.Insert(5);
            maxPriorityQueue.Insert(3);

            Console.WriteLine("Max first priority (default): ");
            while (maxPriorityQueue.Count > 0)
            {
                Console.WriteLine(maxPriorityQueue.Pop());
            }

            BinaryHeap<int> minPriorityQueue = new BinaryHeap<int>(MinIntCompare);
            minPriorityQueue.Insert(4);
            minPriorityQueue.Insert(1);
            minPriorityQueue.Insert(2);
            minPriorityQueue.Insert(5);
            minPriorityQueue.Insert(3);

            Console.WriteLine("Min first (custom comparison passed):");
            while (minPriorityQueue.Count > 0)
            {
                Console.WriteLine(minPriorityQueue.Pop());
            }
        }

        private static int MinIntCompare(int firstItem, int secondItem)
        {
            return firstItem < secondItem ? 1 : firstItem > secondItem ? -1 : 0;
        }
    }
}