//Testing the extension methods and applying LINQ Queries 

namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Extensions;
    using Models;

    class TestsAndLINQ
    {
        static void Main()
        {
            //Testing Problem 1 - StringBuilder Method Extension 

            Console.WriteLine("StringBuilder Substring Method Extension Test: ");
            var input = new StringBuilder();
            input.Append("Hello world!");
            var output = input.Substring(3, 5);

            Console.WriteLine(output);
            Console.WriteLine("--------------------------------------------");


            //Testing Problem 2 - IEnumerable extensions

            Console.WriteLine("Test with List<int>");

            List<int> firstTestCollection = new List<int>() { 12, 3, 56, 67, 106, 57, 2, 1, 777 };
            Console.WriteLine("Sum: {0}", firstTestCollection.Sum());
            Console.WriteLine("Prouct: {0}", firstTestCollection.Product());
            Console.WriteLine("Min: {0}", firstTestCollection.Min());
            Console.WriteLine("Max: {0}", firstTestCollection.Max());
            Console.WriteLine("Average: {0}", firstTestCollection.Average());

            Console.WriteLine();
            Console.WriteLine("Test with an array of type double");

            IEnumerable<double> secondTestCollection = new[] { 12.5, 3.45, 56.1, 67.33, 106, 57.2, 2.77, 1.6, 777.07 };
            Console.WriteLine("Sum: {0}", secondTestCollection.Sum());
            Console.WriteLine("Prouct: {0}", secondTestCollection.Product());
            Console.WriteLine("Min: {0}", secondTestCollection.Min());
            Console.WriteLine("Max: {0}", secondTestCollection.Max());
            Console.WriteLine("Average: {0}", secondTestCollection.Average());
            Console.WriteLine("--------------------------------------------");


            //Testing Problem 3 - First Before Last name of the Student - the test will print the students whose names are 
            //lexicografically before their last names. 

            var studentCollection = GetStudents();

            var result = studentCollection.FirstBeforeLast();
            foreach (Student student in result)
            {
                Console.WriteLine(student.FullName);
            }
            Console.WriteLine("--------------------------------------------");


            //Testing Problem 4 - Age range

            var resultFilterAge = studentCollection.AgeRange(18, 24);
            foreach (var student in resultFilterAge)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("--------------------------------------------");

            //Testing Problem 5 - Order Students in descending order by student's first name and then by his/her last name

            var orderedStudents = studentCollection.OrderStudents();
            foreach (var student in orderedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine("--------------------------------------------");

            //Testing Problem 9 - getting the students only from a certain group 
            //Problem 9. Student groups
            //Create a List<Student> with sample students.Select only the students that are from group number 2.
            //Use LINQ query.Order the students by FirstName.

            var studentsFromGroupsWithLINQ = studentCollection
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToList();

            foreach (var student in studentsFromGroupsWithLINQ)
            {
                Console.WriteLine("{0} from group {1}", student.FullName, student.GroupNumber);
            }


            Console.WriteLine("--------------------------------------------");

            //Problem 10. Student groups extensions
            //Implement the previous using the same query expressed with extension methods.

            var studentsFromGroup = studentCollection.GetStudentGroup(2);
            foreach (var student in studentsFromGroup)
            {
                Console.WriteLine("{0} from group {1}", student.FullName, student.GroupNumber);
            }
            Console.WriteLine("--------------------------------------------");

            //Testing Problem 11:
            //Problem 11. Extract students by email
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.

            var studentsByEmail = studentCollection.ExtractStudentsByEmail("abv.bg");
            foreach (var student in studentsByEmail)
            {
                Console.WriteLine("{0} - {1}", student.FullName, student.Email);
            }
            Console.WriteLine("--------------------------------------------");

            //Testing Problem 12 - extracting students from Sofia by phone number
            //Problem 12. Extract students by phone
            //Extract all students with phones in Sofia.
            //Use LINQ.

            var studentsFromSofia = studentCollection.ExtractStudentsByPhone("+3592");
            foreach (var student in studentsFromSofia)
            {
                Console.WriteLine("{0} - {1}", student.FullName, student.TelephoneNumber);
            }
            Console.WriteLine("--------------------------------------------");


            //Problem 13. Extract students by marks
            //Select all students that have at least one mark Excellent(6) 
            //into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ.

            var studentsWithSix = studentCollection
                .Where(x => x.Marks.Contains(6));

            foreach (var student in studentsWithSix)
            {
                Console.Write("{0} - ", student.FullName);
                foreach (var mark in student.Marks)
                {
                    Console.Write("{0} ", mark);
                };
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");

            //Problem 14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.
            var studentsWithTwo = studentCollection
                .Where(x => x.Marks.FindAll(y => y == 2).ToList().Count == 2)
                .ToList();

            foreach (var student in studentsWithTwo)
            {
                Console.Write("{0} - ", student.FullName);
                foreach (var mark in student.Marks)
                {
                    Console.Write("{0} ", mark);
                };
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");

            //Problem 15.Extract marks
            //Extract all Marks of the students that enrolled in 2006. 
            //(The students from 2006 have 06 as their 5 - th and 6 - th digit in the FN).

            var extractedMarks = studentCollection
                .Where(x => x.FacultyNumber % 10 == 6 && (x.FacultyNumber / 10) % 10 == 0)
                .ToList();
            foreach (var student in extractedMarks)
            {
                Console.Write("{0} - {1} - ", student.FullName, student.FacultyNumber);
                foreach (var mark in student.Marks)
                {
                    Console.Write("{0} ", mark);
                };
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");

            //Problem 16.* Groups
            //Create a class Group with properties GroupNumber and DepartmentName.
            //Introduce a property GroupNumber in the Student class.
            //Extract all students from "Mathematics" department.
            //Use the Join operator // not finished

            var schoolGroups = GetGroups();
            var studentsFromTheMathemathicDepartment = studentCollection
                .Where(x => x.GroupNumber == schoolGroups[1].GroupNumber)
                .ToList();
            foreach (var student in studentsFromTheMathemathicDepartment)
            {
                Console.WriteLine(string.Format("{0} - {1}", student.FullName, schoolGroups[1].Department));

            }

            Console.WriteLine("--------------------------------------------");

            //Problem 18.Grouped by GroupNumber
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            //Use LINQ.

            var groups = from student in studentCollection
                         group student by student.GroupNumber into studentGroups
                         orderby studentGroups.Key
                         select studentGroups;

            foreach (var studentGroup in groups)
            {
                Console.WriteLine(String.Format("GroupNumber = {0}", studentGroup.Key));
                foreach (var student in studentGroup)
                {
                    Console.WriteLine(String.Format("{0}",
                      new object[] { student.FullName}));
                }
            }

            Console.WriteLine("--------------------------------------------");

            //Testing Problem 19

            var anotherGroupingOfStudents = studentCollection.GroupStudentsByGroupNumber();

            foreach (var studentGroup in anotherGroupingOfStudents)
            {
                Console.WriteLine(String.Format("GroupNumber = {0}", studentGroup.Key));
                foreach (var student in studentGroup)
                {
                    Console.WriteLine(String.Format("{0}",
                      new object[] { student.FullName }));
                }

                Console.WriteLine("--------------------------------------------");

            }

        }
        //Creating an IEnumerble<Students> which will be used for testing the extension methods
        //Problem 9. Student groups
        //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks(a List), GroupNumber.

        private static Student[] GetStudents()
        {
            var result = new Student[7];

            result[0] = new Student("Peter", "Mihaylov", 35, 352006, "+3592884337711", "petermihaylov@abv.bg", new List<int>() { 6, 5, 3, 5, 6 }, 2);
            result[1] = new Student("George", "Ivanov", 23, 352053, "+359887777000", "givanov@gmail.com", new List<int>() { 4, 6, 4, 5, 6 }, 3);
            result[2] = new Student("Maria", "Georgieva", 29, 352052, "+359887990090", "maria.georgieva@abv.bg", new List<int>() { 6, 2, 6, 6, 5 }, 2);
            result[3] = new Student("Ivanka", "Marinova", 19, 352006, "+3529883555888", "imarinova@hotmail.bg", new List<int>() { 5, 4, 3, 6, 6 }, 2);
            result[4] = new Student("Kaloyan", "Borisov", 30, 352054, "+359882888999", "kaloyan@abv.bg", new List<int>() { 5, 6, 6, 4, 4 }, 3);
            result[5] = new Student("Ivan", "Petrov", 24, 352006, "+3592883000666", "ipetrov@gmail.com", new List<int>() { 4, 5, 2, 3, 2 }, 1);
            result[6] = new Student("Silvia", "Andreeva", 26, 352056, "+3592885555111", "silviaandreeva@abv.bg", new List<int>() { 5, 5, 3, 5, 4 }, 1);

            return result;
        }

        //Groups 

        private static Group[] GetGroups()
        {
            var result = new Group[3];
            result[0] = new Group(1, "Geography");
            result[1] = new Group(2, "Mathematics");
            result[2] = new Group(3, "Biology");

            return result;
        }

    }
}

