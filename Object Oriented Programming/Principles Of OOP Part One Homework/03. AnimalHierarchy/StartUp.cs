namespace _03.AnimalHierarchy
{
    using Infrastructure.Enumerations;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var dogs = new List<Dog>()
            {
            new Dog("Sharo", 2, GenderType.Male),
            new Dog("Raya", 4, GenderType.Female),
            new Dog("Kuci", 3, GenderType.Male),
            new Dog("Lucky", 6, GenderType.Male),
            new Dog("Sara", 5, GenderType.Female)

        };
            var averageDogAge = dogs.Average(x => x.Age);
            Console.WriteLine("Average dog age: {0:F2} years", averageDogAge);

            var frogs = new List<Frog>()
            {
                new Frog("Froggy", 2, GenderType.Female),
                new Frog("Elza", 5, GenderType.Female),
                new Frog("Bobi", 3, GenderType.Male),
                new Frog("Radi", 1, GenderType.Male),
                new Frog("Kris", 3, GenderType.Female)
            };

            var averageFrogAge = frogs.Average(x => x.Age);
            Console.WriteLine("Average frog age: {0:F2} years", averageFrogAge);

            var cats = new List<Cat>()
            {
                new Kitten("Lucy", 3),
                new Kitten("Kitty", 4),
                new Kitten("Puffy", 2),
                new Kitten("Tania", 6),
                new Tomcat("Tommy", 5),
                new Tomcat("Monsty", 6),
                new Tomcat("Fluffy", 3),
                new Tomcat("Misho", 1)
            };

            var averageCatAge = cats.Average(x => x.Age);
            Console.WriteLine("Aveage cat age: {0:F2}", averageCatAge);

        }
    }
}