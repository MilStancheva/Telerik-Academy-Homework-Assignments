namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;

    [TestClass]
    public class StudentUnitTests
    {
        [TestMethod]
        public void StudentShouldThrowExceptionIfNameIsNull()
        {
            try
            {
                var student = new Student(null, 10000);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void StudentShouldNotThrowException()
        {
            var student = new Student("Ivan Ivanov", 10001);
        }

        [TestMethod]
        public void StudentShouldThrowExceptionIfNameIsEmpty()
        {
            try
            {
                var student = new Student(string.Empty, 10000);
                Assert.Fail();
            }
            catch(ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void StudentShouldReturnTheExpectedName()
        {
            var student = new Student("Ivan Ivanov", 10000);

            Assert.AreEqual("Ivan Ivanov", student.Name);
        }

        [TestMethod]
        public void StudentShouldReturnTheExtectedUniqueNumber()
        {
            var student = new Student("Ivan Ivanov", 10000);

            Assert.AreEqual(10000, student.UniqueNumber);
        }

        [TestMethod]
        public void StudentShouldThrowExceptionIfUniqueNumberIsBelowTheMinimum()
        {
            try
            {
                var student = new Student("Ivan Ivanov", 9999);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        [TestMethod]
        public void StudentShouldThrowExceptionIfUniqueNumberIsAboveMaximum()
        {
            try
            {
                var student = new Student("Ivan Ivanov", 100000);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionIfJoiningACourse()
        {
            var student = new Student("Ivan Ivanov", 10000);
            var course = new Course("High Quality Code");

            student.JoinCourse(course);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenLeavingCourse()
        {
            var student = new Student("Ivan Ivanov", 10000);
            var course = new Course("High Quality Code");

            student.JoinCourse(course);
            student.LeaveCourse(course);
        }

        [TestMethod]
        public void StudentShouldThrowexceptionWhenJoininCourseIfCourseIsNull()
        {
            var student = new Student("Ivan Ivanov", 10000);
            Course course = null;

            try
            {
                student.JoinCourse(course);
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void StudentShouldThrowExceptionWhenLeavingCourseIfCourseIsNull()
        {
            var student = new Student("Ivan Ivanov", 10000);
            Course course = null;

            try
            {
                student.LeaveCourse(course);
                Assert.Fail();
            }
            catch(ArgumentNullException)
            {

            }
        }
    }
}
