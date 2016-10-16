using System;

namespace Problem_3.CompareCharArrays
{
    public class CompareCharArrays
    {
        public static void Main()
        {
            string charArr1 = Console.ReadLine();
            string charArr2 = Console.ReadLine();

            int compared = charArr1.CompareTo(charArr2);

            if (compared == -1)
            {
                Console.WriteLine('<');
            }
            else if (compared == 1)
            {
                Console.WriteLine('>');
            }
            else if (compared == 0)
            {
                Console.WriteLine('=');
            }
        }
    }
}