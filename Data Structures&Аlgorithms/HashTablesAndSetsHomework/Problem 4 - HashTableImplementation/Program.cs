using System;

namespace Problem_4___HashTableImplementation
{
    public class Program
    {
        public static void Main()
        {
            var table = new HashTable<string, int>();

            //add
            table.Add("first", 1);
            table.Add("pesho", 5);
            table.Add("gosho", 3);
            table.Add("stamat", 11);
            table.Add("fifth", 13);
            table.Add("sixth", 6);
            table.Add("seventh", 16);

            Console.WriteLine(string.Join(" ", table));
            Console.WriteLine("Count: {0}", table.Count);

            foreach (var item in table)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
            // contains key
            var key = "pesho";
            Console.WriteLine("Contains {0}? - {1}", key, table.ContainsKey(key));

            // find
            var someValue = table.Find(key);
            Console.WriteLine("{0}'s value is: {1}", key, someValue);

            // indexer
            Console.WriteLine($"Key: {key} is with value: {table[key]}");

            // change value
            table[key] = 3;
            Console.WriteLine("{0}'s value is: {1}", key, table[key]);
            Console.WriteLine(string.Join(" ", table));
            Console.WriteLine("Count: {0}", table.Count);

            // remove 
            table.Remove(key);
            Console.WriteLine("After {0} is removed", key);
            Console.WriteLine(string.Join(" ", table));
            Console.WriteLine("Count: {0}", table.Count);

            // keys property
            var keys = table.Keys;
            Console.WriteLine("Keys: ");
            Console.WriteLine(string.Join(", ", keys));

            // clear
            table.Clear();
            Console.WriteLine("After Clear(): ");
            Console.WriteLine("Count: {0}", table.Count);
        }
    }
}