using System;

namespace Problem_4.MaximalSequence
{
    public class MaximalSequence
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] array = new int[numbersCount];
            int count = 1;
            int maxSequence = 0;


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    if (count >= maxSequence)
                    {
                        maxSequence = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
