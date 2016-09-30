namespace _01.SchoolClasses.Models
{
    using Infrastructure.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string Name, List<Discipline> disciplines) : base(Name)
        {
            this.disciplines = new List<Discipline>();
            foreach (var discipline in disciplines)
            {
                this.disciplines.Add(discipline);
            }
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines);
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The discipline should be set");
                }
                else
                {
                    this.disciplines = value;
                }
            }
        }

        public void AddDisciplines(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format("Teacher: {0}", this.Name));
            builder.AppendLine("Disciplines:");
            //builder.AppendLine(string.Join(", ", this.Disciplines));
            foreach (var discipline in this.Disciplines)
           {
              builder.Append(" " + discipline.Name);
           }
            return builder.ToString();
        }
    }
}