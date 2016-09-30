using System;

namespace Methods
{
    public class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName, DateTime dateOfBirth, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (!this.IsNameValid(value))
                {
                    throw new ArgumentException("FirstName should be valid string in the range of 2 and 30 symbols");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (!this.IsNameValid(value))
                {
                    throw new ArgumentException("LastName should be valid string in the range of 2 and 30 symbols");
                }

                this.lastName = value;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            bool isOlderThanOtherStudent = false;

            DateTime firstStudentBirthday = this.DateOfBirth;
            DateTime secondStudentBirthday = otherStudent.DateOfBirth;

            if (firstStudentBirthday > secondStudentBirthday)
            {
                isOlderThanOtherStudent = false;
            }

            if (firstStudentBirthday <= secondStudentBirthday)
            {
                isOlderThanOtherStudent = true;
            }

            return isOlderThanOtherStudent;
        }

        private bool IsNameValid(string name)
        {
            if (name == null)
            {
                return false;
            }

            if (name.Length < 2 || 30 < name.Length)
            {
                return false;
            }

            return true;
        }
    }
}
