namespace _03.AnimalHierarchy.Models
{
    using Contracts;
    using Infrastructure.Enumerations;
    using System;
    using System.Text;

    public abstract class Animal: ISound
    {
        private string name;
        private int age;
        private GenderType gender;

        public Animal(string name, int age, GenderType gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age should be positive");
                }
                this.age = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public abstract void GetAnimalSound();

     
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine("Animal: " + this.Name);
            builder.AppendLine("Age: " + this.Age);
            builder.AppendLine("Gender: " + this.gender);
            
            return builder.ToString();
        }
    }
}