namespace School.Models
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private ICollection<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.Courses = new List<Course>();
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
                    throw new ArgumentNullException("name", "The school name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }

            private set
            {
                this.courses = value;
            }
        }

        public void AddCoursesToSchool(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            if (this.Courses.Contains(course))
            {
                throw new InvalidOperationException("The course is already added.");
            }

            this.courses.Add(course);
        }

        public void RemoveCourseFromSchool(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Course cannot be null.");
            }

            if (!this.Courses.Contains(course))
            {
                throw new InvalidOperationException("The school does not have such a course.");
            }

            this.courses.Remove(course);
        }
    }
}
