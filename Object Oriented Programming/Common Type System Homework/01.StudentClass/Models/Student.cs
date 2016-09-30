namespace _01.StudentClass.Models
{
    using Infrastructure.Enumerations;
    using System;
    using System.Reflection;
    using System.Text;

    public class Student: ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string socialSecurityNumber;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;
        private SpecialtyType specialty;
        private UniversityType university;
        private FacultyType faculty;

        public Student(string firstName, string middleName, string lastName, string socialSecurityNumber, 
            string permanentAddress, string mobilePhone, string email, int course, SpecialtyType specialty, 
            UniversityType university, FacultyType faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.specialty = specialty;
            this.university = university;
            this.faculty = faculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty.");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }


        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Middle name cannot be null or empty.");
                }
                else
                {
                    this.middleName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string SocialSecurityNumber
        {
            get
            {
                return this.socialSecurityNumber;
            }
            private set
            {
                if (!IsValidSSN(value))
                {
                    throw new ArgumentException("The social security number is not in the correct format. Please use XXX-XX-XXXX where X is digit.");
                }
                else
                {
                    this.socialSecurityNumber = value;
                }
            }

        }

        //ToDo: Implement validation of address, email, mobilephone if needed. 

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            private set
            {
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            private set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentOutOfRangeException("The course should be in the range of 1 to 7 includingly.");
                }
                else
                {
                    this.course = value;
                }
            }
        }

        public UniversityType University { get { return this.university; } }

        public FacultyType Faculty { get {return this.faculty; } }

        public SpecialtyType Specialty { get { return this.specialty; } }

        //The Social Security number is a nine-digit number in the format "AAA-GG-SSSS". 
        //The number is divided into three parts. The area number, the first three digits, is assigned by geographical region.
        private bool IsValidSSN(string ssn)
        {
            if (string.IsNullOrEmpty(ssn) || ssn.Length != 11)
            {
                return false;
            }

            for (int i = 0; i < ssn.Length; i++)
            {
                if (i == 3 || i == 6)
                {
                    if (ssn[i] != '-')
                    {
                        return false;
                    }
                }
                else
                {
                    if (!Char.IsDigit(ssn[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        //Get HashSetCodeAsNumber in order to be compared afterwards in increasing order as per problem 3.

        private int GetSSNAsNumber()
        {
            var numberSSN = new StringBuilder();

            foreach (var symbol in this.SocialSecurityNumber)
            {
                if (Char.IsDigit(symbol))
                {
                    numberSSN.Append(symbol);
                }
            }
            return int.Parse(numberSSN.ToString());
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            foreach (var property in this.GetType().GetRuntimeProperties())
            {
                builder.AppendLine(property.Name + ":" + property.GetValue(this));
            }

            return builder.ToString();
        }

        public override bool Equals(object student)
        {
            var anotherStudent = student as Student;
            if (this.SocialSecurityNumber == anotherStudent.SocialSecurityNumber)
            {
                return true;
            }
            return false; 
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            if (!firstStudent.Equals(secondStudent))
            {
                return false;
            }
            else
            {
                return true;

            }
        } 

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Equals(secondStudent))
            {
                return false;
            }
            else
            {
                return true;

            }
        }

        public override int GetHashCode()
        {
            return this.SocialSecurityNumber.GetHashCode() ^ this.Email.GetHashCode() ^ this.LastName.GetHashCode();
        }

        //Problem 2
        public object Clone()
        {
            return new Student(
                this.FirstName.Clone().ToString(),
                this.MiddleName.Clone().ToString(),
                this.LastName.Clone().ToString(),
                this.SocialSecurityNumber.Clone().ToString(),
                this.PermanentAddress.Clone().ToString(),
                this.MobilePhone.Clone().ToString(),
                this.Email.Clone().ToString(),
                this.Course,
                this.Specialty,
                this.University,
                this.Faculty);
        }

        //Problem 3
        public int CompareTo(Student other)
        {
            string fullName = string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            string otherFullName = string.Format("{0} {1} {2}", other.FirstName, other.MiddleName, other.LastName);

            if (fullName.CompareTo(otherFullName) < 0)
            {
                return -1;
            }
            if (fullName.CompareTo(otherFullName) > 0)
            {
                return 1;
            }
            if (fullName.CompareTo(otherFullName) == 0)
            {
                if (this.GetSSNAsNumber() < other.GetSSNAsNumber())
                {
                    return -1;
                }
                else if (this.GetSSNAsNumber() > other.GetSSNAsNumber())
                {
                    return 1;
                }
                else if (this.GetSSNAsNumber() == other.GetSSNAsNumber())
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}