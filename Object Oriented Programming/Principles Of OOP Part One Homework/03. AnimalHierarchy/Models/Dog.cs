namespace _03.AnimalHierarchy.Models
{
    using System;
    using Infrastructure.Enumerations;
    using Contracts;
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, GenderType gender) : base(name, age, gender)
        {
        }

        public override void GetAnimalSound()
        {
            Console.WriteLine("Djaf djaf djaf");
        }
    }
}