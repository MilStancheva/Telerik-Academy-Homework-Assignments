namespace School.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School.Models;

    [TestClass]
    public class SchoolUnitTests
    {
        [TestMethod]
        public void SchoolShouldNotThrowExceptionWhenCreated()
        {
            var school = new School("Telerik Academy");
        }

        [TestMethod]
        public void SchoolShouldThrowExceptionIfNameIsNull()
        {
            try
            {
                School school = new School(null);
                Assert.Fail();
            }
            catch(ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void SchoolShouldThrowexceptionIfNameIsEmpty()
        {
            try
            {
                School school = new School(string.Empty);
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void SchoolShouldReturnTheCorrectName()
        {
            var school = new School("Telerik Academy");

            Assert.AreEqual("Telerik Academy", school.Name);
        }

        [TestMethod]
        public void SchoolShouldAddCourseCorrectly()
        {
            var school = new School("Telerik Academy");
            var course = new Course("High Quality Code");

            school.AddCoursesToSchool(course);

            Assert.AreEqual(course, school.Courses.First());
        }

        [TestMethod]
        public void SchoolShouldThrowExceptionWhenAddingCourseThatIsNull()
        {
            School school = new School("Telerik Academy");
            Course course = null;

            try
            {
                school.AddCoursesToSchool(course);
                Assert.Fail();
            }
            catch(ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void SchoolShouldThrowExceptionIfTheCourseIsAlreadyAdded()
        {
            School school = new School("telerik Academy");
            Course course = new Course("High Quality Code");

            try
            {
                school.AddCoursesToSchool(course);
                school.AddCoursesToSchool(course);

                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }            
        }

        [TestMethod]
        public void SchoolShouldRemoveCourseCorrectly()
        {
            School school = new School("telerik Academy");
            Course course = new Course("High Quality Code");

            school.AddCoursesToSchool(course);
            school.RemoveCourseFromSchool(course);
        }

        [TestMethod]
        public void SchoolShouldHaveACorectNumberOfCoursesAfterRemovingCourse()
        {
            School school = new School("telerik Academy");
            Course course = new Course("High Quality Code");

            school.AddCoursesToSchool(course);
            school.RemoveCourseFromSchool(course);

            Assert.AreEqual(0, school.Courses.Count);
        }

        [TestMethod]
        public void SchoolShouldThrowExceptionIfCourseToBeRemovedIsNull()
        {
            School school = new School("Telerik Academy");
            Course course = null;

            try
            {
                school.RemoveCourseFromSchool(course);
                Assert.Fail();
            }
            catch(ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void SchoolShouldThrowExceptionIfTheCourseToBeRemovedDoesNotExsist()
        {
            School school = new School("telerik Academy");
            Course course = new Course("High Quality Code");

            try
            {
                school.RemoveCourseFromSchool(course);
                Assert.Fail();
            }
            catch(InvalidOperationException)
            {
               
            }
        }
    }
}
