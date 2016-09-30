namespace _03.AnimalHierarchy.Models
{
    using System;
    using Infrastructure.Enumerations;

    public class Cat : Animal
    {
        public Cat(string name, int age, GenderType gender) : base(name, age, gender)
        {
        }

        public override void GetAnimalSound()
        {
            Console.WriteLine("Mewwwww mewwww mewwwwww");
        }
    }
}