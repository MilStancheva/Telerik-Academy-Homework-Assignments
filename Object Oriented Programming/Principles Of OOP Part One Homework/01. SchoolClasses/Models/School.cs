namespace _01.SchoolClasses.Models
{
    using System.Collections.Generic;

    public abstract class School
    {
        private List<SchoolClass> classes;
        private string name;

        public School(string name)
        {
            this.name = name;
            this.classes = new List<SchoolClass>();
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

        public void AddClass(SchoolClass schoolClass)
        {
            this.classes.Add(schoolClass);
        }

        public List<SchoolClass> GetClasses()
        {
            return new List<SchoolClass>(this.classes);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}