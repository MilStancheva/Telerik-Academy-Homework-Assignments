using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class Course
    {
        private string InvalidCouseNameExceptionMessage = "Name of the course cannot be null or empty.";
        private string InvalidTeachersNameExceptionMessage = "Name of the teacher cannot be null or empty.";
        private string InvalidStudentNameExceptionMessage = "Name of a student cannot be null or empty.";
        
        private string courseName;
        private string teachersName;
        private ICollection<string> students = new List<string>();

        protected Course(string courseName)
        {
            this.courseName = courseName;
            this.Students = new List<string>();
        }

        protected Course(string courseName, string teachersName)
            : this(courseName)
        {
            this.teachersName = teachersName;
        }

        protected Course(string courseName, string teachersName, ICollection<string> students)
            : this(courseName, teachersName)
        {
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(InvalidCouseNameExceptionMessage);
                }

                this.courseName = value;
            }
        }

        public string TeachersName
        {
            get
            {
                return this.teachersName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(InvalidTeachersNameExceptionMessage);
                }

                this.teachersName = value;
            }
        }

        public ICollection<string> Students { get; private set; }
        
        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            string courseType = this.GetType().Name;
            string courseName = string.Format("Name = {0}", this.CourseName);
            string teacherName = string.Format("Teacher = {0}", this.TeachersName);
            string students = string.Empty;

            if (this.Students.Count > 0)
            {
                students = string.Format("Students = {0}", this.GetStudentsAsString());
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine(courseType);
            result.AppendLine(courseName);
            result.AppendLine(teacherName);
            result.AppendLine(students);

            return result.ToString().Trim();
        }

        private void AddStudents(ICollection<string> strudents)
        {
            if (this.students != null)
            {
                foreach (var student in this.students)
                {
                    if (string.IsNullOrEmpty(student))
                    {
                        throw new ArgumentException(InvalidStudentNameExceptionMessage);
                    }

                    this.Students.Add(student);
                }
            }
        }
    }
}