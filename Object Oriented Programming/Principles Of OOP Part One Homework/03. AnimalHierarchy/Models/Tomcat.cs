namespace _03.AnimalHierarchy.Models
{
    using Infrastructure.Enumerations;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, GenderType.Male)
        {
        }
    }
}