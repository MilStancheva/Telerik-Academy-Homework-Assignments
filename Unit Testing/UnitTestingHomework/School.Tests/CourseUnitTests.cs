namespace School.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School.Models;

    [TestClass]
    public class CourseUnitTests
    {
        [TestMethod]
        public void CourseShouldThrowAnExceptionIfNameIsNull()
        {
            try
            {
                Course course = new Course(null);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void CourseShouldThrowAnExceptionIfNameIsEmpty()
        {
            try
            {
                Course course = new Course(string.Empty);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void CourseShouldReturnNameCorrectly()
        {
            var course = new Course("Maths");
            Assert.AreEqual("Maths", course.Name);
        }

        [TestMethod]
        public void CourseShouldAddStudentCorrectly()
        {
            var course = new Course("High-Quality Code");
            var student = new Student("Ivan Ivanov", 10001);

            course.AddStudentToCourse(student);

            Assert.AreEqual(student, course.Students.FirstOrDefault());
        }

        [TestMethod]
        public void CourseShouldThrowExceptionIfStudentIsNullWhenAdding()
        {
            var course = new Course("High-Quality Code");
            Student student = null;

            try
            {
                course.AddStudentToCourse(student);
                Assert.Fail();
            }
            catch (NullReferenceException)
            {

            }
        }

        [TestMethod]
        public void CourseShouldThrowExceptionWhenAddingAnAlreadyExistinginTheCourseStudent()
        {
            var course = new Course("High-Quality Code");
            var student = new Student("Ivan Ivanov", 10001);

            try
            {
                course.AddStudentToCourse(student);
                course.AddStudentToCourse(student);

                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

        }

        [TestMethod]
        public void CourseShouldThrowExceptionIfHasReachedItsMaximumCountOfStudentsAndCannotAddAnother()
        {
            var course = new Course("High-Quality Code");

            try
            {
                for (int i = 0; i < 32; i++)
                {
                    course.AddStudentToCourse(new Student(string.Format("Name{0}", i.ToString()), 10000 + i));
                }
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }

        }

        [TestMethod]
        public void CourseShouldRemoveStudentCorrectly()
        {
            var course = new Course("High-Quality Code");
            var student = new Student("Ivan Ivanov", 10001);

            course.AddStudentToCourse(student);
            course.RemoveStudentFromCourse(student);

            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        public void CourseShouldThrowExceptionWhenRemovingAnUnexistingStudent()
        {
            var course = new Course("High-Quality Code");
            var student = new Student("Pesho Peshov", 10000);

            try
            {
                course.RemoveStudentFromCourse(student);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void CourseShouldThrowExceptionWhenRemovingANullStudent()
        {
            var course = new Course("High-Quality Code");
            Student student = null;

            try
            {
                course.RemoveStudentFromCourse(student);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }
    }
}
