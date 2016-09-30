namespace _03.AnimalHierarchy.Models
{
    using Infrastructure.Enumerations;

    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, GenderType.Female)
        {

        }
    }
}