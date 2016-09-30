using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Interval
{
    public class Interval
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long m = long.Parse(Console.ReadLine());

            long counter = 0;

            if (n >= 0 && m >= n && m <= 2000)
            {
                for (long i = (n + 1); i < m; i++)
                {
                    if (i % 5 == 0)
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);
            }
        }
    }
}