using System;

namespace RefactoringLoop
{
    public class StartpRefactoringLoop
    {
        public static void Main(string[] args)
        {
            int sequenceLength = 100;
            var sequence = GenerateArray(sequenceLength);
            int expectedValue = 50;

            for (int index = 0; index < sequence.Length; index++)
            {
                if (index % 10 == 0)
                {
                    Console.WriteLine(sequence[index]);
                    if (sequence[index] == expectedValue)
                    {
                        Console.WriteLine("Value found at index: {0}", index);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private static int[] GenerateArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            return array;
        }
    }
}