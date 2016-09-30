using System;

namespace _07.SortThreeNumbers
{
    public class SortThreeNumbers
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int biggest = 0;
            int middle = 0;
            int smallest = 0;

            if (a > -1000 && a < 1000 && b > -1000 && b < 1000 && c > -1000 && c < 1000)
            {
                if (a >= b && a >= c)
                {
                    biggest = a;
                }
                else if (b >= a && b > +c)
                {
                    biggest = b;
                }
                else if (c >= a && c >= b)
                {
                    biggest = c;
                }

                if (a <= b && a <= c)
                {
                    smallest = a;
                }
                else if (b <= a && b <= c)
                {
                    smallest = b;
                }
                else if (c <= a && c <= b)
                {
                    smallest = c;
                }

                if ((a >= b && b >= c) || (c >= b && b >= a))
                {
                    middle = b;
                }
                else if ((b >= a && a >= c) || (c >= a && a >= b))
                {
                    middle = a;
                }
                else
                {
                    middle = c;
                }

                Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
            }
        }
    }
}


