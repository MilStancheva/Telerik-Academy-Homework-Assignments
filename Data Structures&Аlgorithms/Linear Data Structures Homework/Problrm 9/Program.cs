/*
    We are given the following sequence:
    S1 = N;
    S2 = S1 + 1;
    S3 = 2*S1 + 1;
    S4 = S1 + 2;
    S5 = S2 + 1;
    S6 = 2*S2 + 1;
    S7 = S2 + 2;
    ...
    Using the Queue<T> class write a program to print its first 50 members for given N.
    Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a start number N:");
            int n = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            int count = 50;
            for (int i = 0; i < count; i++)
            {
                int currentNumber = queue.Dequeue();

                queue.Enqueue(currentNumber + 1);
                Console.WriteLine(queue.Last());

                queue.Enqueue(2 * currentNumber + 1);
                Console.WriteLine(queue.Last());

                queue.Enqueue(currentNumber + 2);
                Console.WriteLine(queue.Last());
            }
        }
    }
}