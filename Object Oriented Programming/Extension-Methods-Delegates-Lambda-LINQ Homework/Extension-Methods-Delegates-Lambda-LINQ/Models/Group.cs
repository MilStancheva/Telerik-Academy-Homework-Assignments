//Problem 16.* Groups
//Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property GroupNumber in the Student class.
//Extract all students from "Mathematics" department.
//Use the Join operator.

namespace Extension_Methods_Delegates_Lambda_LINQ.Models
{
    public class Group
    {
        public Group(int groupNumber, string department)
        {
            this.GroupNumber = groupNumber;
            this.Department = department;
        }
        public int GroupNumber { get; set; }

        public string Department { get; set; }
    }
}
