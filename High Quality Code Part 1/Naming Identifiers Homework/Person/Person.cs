using Person.Enumerations;

namespace Person
{
    public class Person
    {
        public Person(int age)
        {
            this.Age = age;

            if (age % 2 == 0)
            {
                this.Name = Names.CoolGuy;
                this.Gender = GenderType.Man;
            }
            else
            {
                this.Name = Names.HotGirl;
                this.Gender = GenderType.Woman;
            }
        }

        public GenderType Gender { get; set; }

        public Names Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, gender: {1}, age: {2}", this.Name, this.Gender, this.Age);
        }
    }
}