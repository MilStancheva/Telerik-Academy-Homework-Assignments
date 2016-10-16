using System;

namespace Problem_9.FrequentNumber
{
    public class FrequentNumber
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            int sortedNum;
            int frequentNum = 0;
            int counter = 1;
            int maxCounter = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        sortedNum = arr[i];
                        arr[i] = arr[j];
                        arr[j] = sortedNum;
                    }
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    frequentNum = arr[i];
                }
                counter = 1;

            }
            Console.WriteLine("{0} ({1} times)", frequentNum, maxCounter);
        }
    }
}