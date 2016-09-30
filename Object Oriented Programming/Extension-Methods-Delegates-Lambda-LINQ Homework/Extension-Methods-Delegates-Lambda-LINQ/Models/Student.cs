//Problem 9. Student groups
//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks(a List), GroupNumber.
//Create a List<Student> with sample students.Select only the students that are from group number 2.
//Use LINQ query.Order the students by FirstName.

namespace Extension_Methods_Delegates_Lambda_LINQ.Models
{
    using System.Collections.Generic;

    public class Student
    {
        public Student()
        {

        }

        public Student(string firstName, string lastName, int age, int facultyNumber, string telephoneNumber, string email,
                        List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.TelephoneNumber = telephoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string TelephoneNumber { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
