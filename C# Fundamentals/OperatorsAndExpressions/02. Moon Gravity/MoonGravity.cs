using System;

public class MoonGravity
{
    public static void Main()
    {
        double earthWeight = double.Parse(Console.ReadLine());

        if (earthWeight > 1 && earthWeight < 1000)
        {
            double moonWeight = earthWeight * 0.17;
            Console.WriteLine("{0:0.000}", moonWeight);
        }
    }
}