namespace _03.AnimalHierarchy.Models
{
    using System;
    using Infrastructure.Enumerations;

    public class Frog : Animal
    {
        public Frog(string name, int age, GenderType gender) : base(name, age, gender)
        {
        }

        public override void GetAnimalSound()
        {
            Console.WriteLine("Kvaak kvaaak");
        }
    }
}