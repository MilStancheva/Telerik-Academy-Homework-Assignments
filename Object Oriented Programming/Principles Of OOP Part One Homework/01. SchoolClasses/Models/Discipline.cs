namespace _01.SchoolClasses.Models
{
    using _01.SchoolClasses.Infrastructure.Contracts;
    using _01.SchoolClasses.Infrastructure.Enumerations;
    using System;

    public class Discipline : ICommentable
    {
        private DisciplineType name;
        private int numberOfLectures;
        private int numberOfExcersises;
        private string comment;


        public Discipline(DisciplineType name)
        {
            this.Name = name;
        }

        public Discipline(DisciplineType name, int numberOfLectures, int numberOfExcersises) : this(name)
        {
            this.numberOfLectures = numberOfLectures;
            this.numberOfExcersises = numberOfExcersises;
        }

        public DisciplineType Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of lectures should be positive");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcersises
        {
            get
            {
                return this.numberOfExcersises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of excersises should be positive");
                }
                this.numberOfExcersises = value;
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

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}