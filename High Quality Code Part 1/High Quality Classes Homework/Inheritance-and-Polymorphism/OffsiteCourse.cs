using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        private string InvalidTownNameExceptionMessage = "Name of town cannot be null or empty";
        private string town;

        public OffsiteCourse(string courseName, string teachersName, ICollection<string> students, string town)
            : base(courseName, teachersName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(InvalidTownNameExceptionMessage);
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.AppendLine(string.Format("Town = {0}", this.Town));

            return builder.ToString();
        }
    }
}
