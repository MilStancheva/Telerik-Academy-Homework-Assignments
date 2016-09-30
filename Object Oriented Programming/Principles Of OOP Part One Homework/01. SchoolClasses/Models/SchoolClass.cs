namespace _01.SchoolClasses.Models
{
    using Infrastructure.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SchoolClass : ICommentable
    {
        private string id;
        private List<Teacher> teachers;
        private List<Student> students;
        private string comment;

        public SchoolClass(string id, List<Teacher> teachers, List<Student> students)
        {
            this.id = id;
            this.teachers = new List<Teacher>();
            this.teachers.AddRange(teachers);
            this.students = new List<Student>();
            this.students.AddRange(students);

        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Unique text identifier is required. Please, set it with text characters.");
                }
                this.id = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }

        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
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

        public void AddTeacher (Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher (Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public void AddStudent (Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent (Student student)
        {
            this.students.Remove(student);
        }


        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("Class {0}", this.Id));
            builder.AppendLine(string.Format("Teachers: {0}", string.Join(", ", this.Teachers)));
            builder.AppendLine(string.Format("Students: {0}", string.Join(", ", this.Students)));
            
            return builder.ToString();
        }
    }
}