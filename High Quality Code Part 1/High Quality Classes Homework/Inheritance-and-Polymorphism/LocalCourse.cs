using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        private string InvalidLabNameExceptionMessage = "Name of the lab cannot be null or empty.";
        private string lab;

        public LocalCourse(string courseName, string teachersName, ICollection<string> students, string lab) 
            : base(courseName, teachersName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(InvalidLabNameExceptionMessage);
                }

                this.lab = value;
            }
        }  

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.AppendLine(string.Format("Lab = {0}", this.Lab));
                        
            return builder.ToString();
        }
    }
}
