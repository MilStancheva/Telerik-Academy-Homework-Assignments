using System;

namespace _09.MatrixOfNumbers
{
    public class MatrixOfNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int edge = n;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= edge; j++)
                {
                    Console.Write("{0} ", j);
                }

                Console.WriteLine();
                edge++;
            }
        }
    }
}