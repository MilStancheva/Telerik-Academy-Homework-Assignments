namespace _04.PersonClass.Models
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please fill in the name of the person");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                return string.Format("Name: {0}; Age: not specified", this.Name);
            }
            else
            {
                return string.Format("Name: {0}; Age: {1}", this.Name, this.Age);
            }            
        }
    }
}