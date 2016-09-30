using System;

namespace IntroToProgramming
{
    public class Age
    {
        public static void Main()
        {
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int age = (int)((now - birthday).TotalDays / 365.242199);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your age after 10 years will be: {0}", age + 10);
        }
    }
}