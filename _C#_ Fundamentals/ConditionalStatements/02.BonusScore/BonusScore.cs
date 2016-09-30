using System;

namespace _02.BonusScore
{
    public class BonusScore
    {
        public static void Main()
        {
            int score = int.Parse(Console.ReadLine());

            if (score > 0 && score <= 3)
            {
                score *= 10;
                Console.WriteLine(score);
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
                Console.WriteLine(score);
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
                Console.WriteLine(score);
            }
            else if (score <= 0 || score > 9)
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
