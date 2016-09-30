using System;

namespace Person
{
    class StartUpPerson
    {
        public static void Main(string[] args)
        {
            var firstPerson = new Person(27);
            Console.WriteLine(firstPerson.ToString());

            var secondPerson = new Person(30);
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
