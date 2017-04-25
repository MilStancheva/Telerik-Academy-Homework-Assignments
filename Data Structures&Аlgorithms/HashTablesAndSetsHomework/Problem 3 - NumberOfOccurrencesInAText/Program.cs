using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3___NumberOfOccurrencesInAText
{
    public class Program
    {
        public static void Main()
        {
            var stream = new StreamReader("../../file.txt");
            var text = stream.ReadLine();
            var wordsAndNumberOfTheirOccurrences = CalculateCountOfEachWordInText(text);
            PrintWordsAndTheNumberOfTheirOccurrences(wordsAndNumberOfTheirOccurrences);
        }

        private static IDictionary<string, int> CalculateCountOfEachWordInText(string text)
        {
            var result = new SortedDictionary<string, int>();
            string[] words = text.Split(new char[] { ',', ' ', '.', '!', '?', '—', '–', '-' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word => word.ToLower())
                .ToArray();

            foreach (var word in words)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result.Add(word, 1);
                }
            }

            return result;
        }

        private static void PrintWordsAndTheNumberOfTheirOccurrences(IDictionary<string, int> wordsAndNumberOfTheirOccurrences)
        {
            var orderedWords = wordsAndNumberOfTheirOccurrences.OrderBy(word => word.Value);
            foreach (var word in orderedWords)
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
            }
        }
    }
}