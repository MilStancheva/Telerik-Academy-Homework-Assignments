using System;

namespace Problem_1.AllocateArray
{
    public class AllocateArray
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                //int number = int.Parse(Console.ReadLine());
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }
}
