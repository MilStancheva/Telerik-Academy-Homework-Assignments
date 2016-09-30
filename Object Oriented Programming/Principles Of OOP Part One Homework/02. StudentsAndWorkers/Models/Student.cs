namespace _02.StudentsAndWorkers.Models
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        public Student(string firstName, string lastName, int grade) : this(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("The grade should be in the range of 2 and 6.");
                }
                this.grade = value;
            }
                
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format("Student: {0} {1}", this.FirstName, this.LastName));
            builder.AppendLine(string.Format("Grade: {0}", this.Grade));   

            return builder.ToString();
        }
    }
}