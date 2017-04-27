using System;

namespace Problem_5___HashSetImplementation
{
    public class Program
    {
        public static void Main()
        {
            var set = new HashedSet<string>();

            //add
            set.Add("first");
            set.Add("pesho");
            set.Add("gosho");
            set.Add("stamat");
            set.Add("fifth");
            set.Add("sixth");
            set.Add("seventh");

            Console.WriteLine(string.Join(" ", set));
            Console.WriteLine("Count: {0}", set.Count);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            // contains key
            var key = "pesho";
            Console.WriteLine("Contains {0}? - {1}", key, set.Contains(key));

            //// find
            //var someValue = set.Find(key);
            //Console.WriteLine("{0}'s value is: {1}", key, someValue);

            // remove 
            set.Remove(key);
            Console.WriteLine("After {0} is removed", key);
            Console.WriteLine(string.Join(" ", set));
            Console.WriteLine("Count: {0}", set.Count);

            // union
            var otherSet = new HashedSet<string>() { "ananas", "pesho" };
            var unionSet = set.Union(otherSet);
            Console.WriteLine("After Union(): ");
            Console.WriteLine(string.Join(", ", unionSet));

            // intersect
            set.Add("pesho");
            var intersectSet = set.Intersect(otherSet);
            Console.WriteLine("After Intersect(): ");
            Console.WriteLine(string.Join(", ", intersectSet));
            
            // clear
            set.Clear();
            Console.WriteLine("After Clear(): ");
            Console.WriteLine("Count: {0}", set.Count);
        }
    }
}