namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using Contracts;

    public class Course : ICourse
    {
        private const int MaximalCountOfStudentsInCourse = 30;

        private string name;
        private ICollection<IStudent> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<IStudent>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null");
                }

                this.name = value;
            }
        }

        public ICollection<IStudent> Students
        {
            get
            {
                return new List<IStudent>(this.students);
            }

            private set
            {
                if (value.Count > MaximalCountOfStudentsInCourse)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Students in course should be less than {0}", MaximalCountOfStudentsInCourse));
                }

                this.students = value;
            }
        }

        public void AddStudentToCourse(Student student)
        {
            if (student == null)
            {
                throw new NullReferenceException("Student cannot be null");
            }

            if (this.Students.Count > 30)
            {
                throw new InvalidOperationException("Students' count in the course is already at its maximum value.");
            }

            if (this.Students.Contains(student))
            {
                throw new InvalidOperationException("This student has already joined the course");
            }

            this.students.Add(student);
        }

        public void RemoveStudentFromCourse(Student student)
        {
            if (student == null)
            {
                throw new InvalidOperationException("Student cannot be null.");
            }

            if (!this.Students.Contains(student))
            {
                throw new InvalidOperationException("The student does not attend this cousre.");
            }

            this.students.Remove(student);
        }
    }
}
