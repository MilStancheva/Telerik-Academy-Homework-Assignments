
namespace Extension_Methods_Delegates_Lambda_LINQ.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Extension_Methods_Delegates_Lambda_LINQ.Models;

    public static class StudentExtensions
    {
        //Problem 3. First before last
        //Write a method that from a given array of students finds all students whose 
        //first name is before its last name alphabetically.
        //Use LINQ query operators.

        public static IEnumerable<T> FirstBeforeLast<T>(this IEnumerable<T> students) where T : Student
        {
            var result = students.
                Where(x => (x.FirstName).CompareTo(x.LastName) < 0);

            return result;
        }


        //Problem 4. Age range
        //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

        public static IEnumerable<string> AgeRange<T>(this IEnumerable<T> students, int min, int max) where T : Student
        {
            var result = students
                .Where(x => (x.Age >= min && x.Age <= max))
                .Select(x => String.Format("{0} {1} - {2}", x.FirstName, x.LastName, x.Age))
                .ToArray();

            return result;
        }

        //Problem 5. Order students
        //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
        //first name and last name in descending order.
        //Rewrite the same with LINQ.

        public static IEnumerable<T> OrderStudents<T>(this IEnumerable<T> students) where T : Student
        {
            var result = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .ToArray();

            return result;
        }

        //Problem 9. Student groups
        //Create a List<Student> with sample students.Select only the students that are from group number 2.
        //Use LINQ query.Order the students by FirstName.
        //Problem 10. Student groups extensions
        //Implement the previous using the same query expressed with extension methods.

        public static IEnumerable<T> GetStudentGroup<T>(this IEnumerable<T> students, int group) where T : Student
        {
            var result = students
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToList();

            return result;
        }

        //Problem 11. Extract students by email
        //Extract all students that have email in abv.bg.
        //Use string methods and LINQ.

        public static IEnumerable<T> ExtractStudentsByEmail<T>(this IEnumerable<T> students, string email) where T : Student
        {
            var result = students
                .Where(x => x.Email.Split('@').Last() == email)
                .ToArray();

            return result;
        }

        //Problem 12. Extract students by phone
        //Extract all students with phones in Sofia.
        //Use LINQ.

        public static IEnumerable<T> ExtractStudentsByPhone<T>(this IEnumerable<T> students, string cityCode) where T : Student
        {
            var result = students
                .Where(x => x.TelephoneNumber.Substring(0, 5) == cityCode)
                .ToArray();

            return result;
        }

        //Problem 18. Grouped by GroupNumber
        //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
        //Use LINQ.
        //Problem 19. Grouped by GroupName extensions
        //Rewrite the previous using extension methods.
        public static IEnumerable<IGrouping<int, T>> GroupStudentsByGroupNumber<T>(this IEnumerable<T> students) where T : Student
        {
            var result = students
                           .OrderBy(x => x.GroupNumber)
                           .GroupBy(x => x.GroupNumber);

            return result;
        }

    }
}
