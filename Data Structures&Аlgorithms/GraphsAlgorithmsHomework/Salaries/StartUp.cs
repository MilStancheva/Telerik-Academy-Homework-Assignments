using System;

namespace Salaries
{
    public class StartUp
    {
        const int MaxCount = 51;
        static int c;
        static long[] cache = new long[MaxCount];
        static bool[,] matrix = new bool[MaxCount, MaxCount];

        public static void Main(string[] args)
        {
            c = int.Parse(Console.ReadLine());
            //Read adjacancy matrix
            for (int i = 0; i < c; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < c ; j++)
                {
                    if (line[j] == 'Y')
                    {
                        matrix[i, j] = true;
                    }
                }
            }

            // Sum all salaries
            long sumOfSalaries = 0;
            for (int i = 0; i < c; i++)
            {
                sumOfSalaries += FindSalary(i);
            }

            Console.WriteLine(sumOfSalaries);
        }

        private static long FindSalary(int employee)
        {
            
            if (cache[employee] > 0)
            {
                return cache[employee];
            }            

            long salary = 0;
            for (int i = 0; i < c; i++)
            {
                if (matrix[employee, i] == true)
                {
                    salary += FindSalary(i);
                }
            }

            if (salary == 0)
            {
                salary = 1;
            }

            cache[employee] = salary;
            return salary;
        }
    }
}