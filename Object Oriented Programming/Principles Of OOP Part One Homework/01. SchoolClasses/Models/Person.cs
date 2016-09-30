namespace _01.SchoolClasses.Models
{
    using Infrastructure.Contracts;
    using System;

    public abstract class Person: ICommentable
    {
        private string name;
        private string comment;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }

        }

        public string Comment
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.comment))
                {
                    return "There is no comment yet";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }       
    }
}