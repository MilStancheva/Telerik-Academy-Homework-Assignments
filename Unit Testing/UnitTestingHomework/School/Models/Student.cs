namespace School.Models
{
    using System;
    using Contracts;

    public class Student : IStudent
    {
        private const int MinUniqueNumber = 10000;
        private const int MaxUniqueNumber = 99999;

        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
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
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            private set
            {
                if (value < MinUniqueNumber || value > MaxUniqueNumber)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The unique number should be in te range [{0} - {1}]", MinUniqueNumber, MaxUniqueNumber));
                }

                this.uniqueNumber = value;
            }
        }

        public void JoinCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null");
            }

            course.AddStudentToCourse(this);
        }

        public void LeaveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null");
            }

            course.RemoveStudentFromCourse(this);
        }
    }
}
