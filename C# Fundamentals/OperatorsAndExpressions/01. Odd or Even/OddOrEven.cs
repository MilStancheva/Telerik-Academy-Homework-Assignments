using System;

public class OddOrEven
{
    public static void Main()
    {
        int numberToBeChecked = int.Parse(Console.ReadLine());

        if (numberToBeChecked > -30 && numberToBeChecked < 30)
        {
            int result = numberToBeChecked % 2;

            if (result == 0)
            {
                Console.WriteLine("even {0}", numberToBeChecked);
            }
            else
            {
                Console.WriteLine("odd {0}", numberToBeChecked);
            }
        }

    }
}