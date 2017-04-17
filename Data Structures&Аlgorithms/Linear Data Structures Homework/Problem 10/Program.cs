/*
    We are given numbers N and M and the following operations:
    N = N+1
    N = N+2
    N = N*2
    Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
    Hint: use a queue.
    Example: N = 5, M = 16
    Sequence: 5 → 7 → 8 → 16
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10_ShortestSequenceOfOperations
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a start number N:");
            int startNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter an end number M:");
            int endNumber = int.Parse(Console.ReadLine());

            Queue<int> operations = new Queue<int>();

            while (startNumber <= endNumber)
            {
                operations.Enqueue(endNumber);

                if (endNumber / 2 >= startNumber)
                {
                    if (endNumber % 2 == 0)
                    {
                        endNumber /= 2;
                    }
                    else
                    {
                        endNumber--;
                    }
                }
                else
                {
                    if (endNumber - 2 >= startNumber)
                    {
                        endNumber -= 2;
                    }
                    else
                    {
                        endNumber--;
                    }
                }
            }

            Console.WriteLine(string.Join(" -> ", operations.Reverse()));            
        }
    }
}