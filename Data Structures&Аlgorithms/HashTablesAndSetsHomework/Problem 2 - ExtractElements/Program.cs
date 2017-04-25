using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2___ExtractElements
{
    public class Program
    {
        public static void Main()
        {
            string[] words = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var wordsThatOccurOddNumberOdTimes = ExtractWordsThatAppearOddNumberOfTimes(words);
            PrintResult(words, wordsThatOccurOddNumberOdTimes);
        }

        private static ISet<string> ExtractWordsThatAppearOddNumberOfTimes(string[] words)
        {
            var result = new HashSet<string>();

            IDictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (occurrences.ContainsKey(word))
                {
                    occurrences[word]++;
                }
                else
                {
                    occurrences[word] = 1;
                }
            }

            foreach (var word in occurrences)
            {
                if (occurrences[word.Key] % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }

            return result;
        }

        private static void PrintResult(string[] words, ISet<string> wordsThatOccureOddNumberOfTimes)
        {
            var builder = new StringBuilder();
            builder.Append("{ ");
            builder.Append(string.Join(", ", words));
            builder.Append(" } ");
            builder.Append(" -> ");
            builder.Append("{ ");
            builder.Append(string.Join(", ", wordsThatOccureOddNumberOfTimes));
            builder.Append(" } ");

            Console.WriteLine(builder.ToString());
        }
    }
}