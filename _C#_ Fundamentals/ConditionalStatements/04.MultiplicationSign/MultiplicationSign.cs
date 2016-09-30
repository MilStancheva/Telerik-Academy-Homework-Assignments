﻿using System;

namespace _04.MultiplicationSign
{
    public class MultiplicationSign
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if ((a < 0 && b > 0 && c > 0) || (b < 0 && c > 0 && a > 0) || (c < 0 && a > 0 && b > 0) || (a < 0 && b < 0 && c < 0))
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0 || a < 0 && c < 0 || b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
        }
    }
}