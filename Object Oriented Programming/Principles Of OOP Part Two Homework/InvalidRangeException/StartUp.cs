namespace InvalidRangeException
{
    using System;

    public class StartUp
    {
        IFormatProvider culture = new System.Globalization.CultureInfo("bg-BG", true);

        public static void Main()
        {
            Console.WriteLine("Please, enter a number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Please try again and enter a number in the range of 1 to 100.", 1, 100);
                }
            }
            catch (InvalidRangeException<int> ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Please, enter a date: ");

            try
            {
                string input = Console.ReadLine(); // Please, enter in the format: YYYY, MM, dd
                DateTime date = Convert.ToDateTime(input);

                if (date < new DateTime(1980, 01, 01) || date > new DateTime(2013, 12, 31) )
                {
                    throw new InvalidRangeException<DateTime>
                        ("Invalid date. The date should be after 1.1.1980 and before 31.12.2013", 
                        new DateTime(1980, 01, 01), new DateTime(2013, 12, 31));
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}