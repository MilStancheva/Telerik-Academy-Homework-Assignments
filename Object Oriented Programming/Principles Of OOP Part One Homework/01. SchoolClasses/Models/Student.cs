namespace _01.SchoolClasses.Models
{
    using _01.SchoolClasses.Infrastructure.Contracts;

    public class Student : Person, ICommentable
    {
        public Student(string Name, int UniqueClassNumber) : base(Name)
        {
            this.UniqueClassNumber = UniqueClassNumber;
        }

        public int UniqueClassNumber { get; set; }
   
        public override string ToString()
        {
            return string.Format("Student: {0}: {1}", this.Name, this.UniqueClassNumber);
        }

    }
}