//Problems 1, 2, 3

namespace _01.StudentClass
{
    using Infrastructure.Enumerations;
    using Models;
    using System;

    public class StartUp
    {
        static void Main()
        {
            Student test = new Student("Yasen", "Vasilev", "Petrov", "123-45-6789", "Sofia, Razsadnika 5", "+359 888 123 456",
               "petrov_yasen@gmail.com", 5, SpecialtyType.Law, UniversityType.NewBulgarianUniversity, FacultyType.LegalStudies);

            // Student test2 is the same as test in everything, but SSN
            Student test2 = new Student("Yasen", "Vasilev", "Petrov", "193-45-6889", "Sofia, Razsadnika 5", "+359 888 123 456",
               "petrov_yasen@gmail.com", 5, SpecialtyType.Law, UniversityType.NewBulgarianUniversity, FacultyType.LegalStudies);

            // Student test3 - some different properties, but the same SSN as test
            Student test3 = new Student("Maria", "Vasileva", "Petrova", "123-45-6789", "Sofia, Mladost 4", "+359 888 111 454",
               "mariika@abv.bg", 2, SpecialtyType.Tourism, UniversityType.SofiaUniversity, FacultyType.Tourism);

            bool compare1and2 = test.Equals(test2);
            bool compare1and3 = test.Equals(test3);
            bool compareWithOperators1and2 = (test == test2);
            bool compareWithOperators1and3 = (test == test3);
            int newHashCode = test.GetHashCode();

            Console.WriteLine(test); // test toString
            Console.WriteLine("Compare student 1 and student 2 using Equals: {0}\n" +
                              "Compare student 1 and student 3 using Equals: {1}\n" +
                              "Compare student 1 and student 2 using ==: {2}\n" +
                              "Compare student 1 and student 3 using ==: {3}\n",
                              compare1and2, compare1and3, compareWithOperators1and2, compareWithOperators1and3);
            Console.WriteLine("New HashCode of student 1: {0}", newHashCode);

            Student clonedStudent = (Student)test.Clone();

            Console.WriteLine("test.CompareTo(test2): {0}", test.CompareTo(test2)); // (-1): names are the same, but test's SSN < test2's SSN
            Console.WriteLine("test.CompareTo(test3): {0}", test.CompareTo(test3)); // (1): Yasen(test) is after Maria(test3) lexicographically

            Console.WriteLine("Cloned student equals {0}? {1}", test.FirstName, clonedStudent == test);
            test = test2; // change test, now it's different from cloned
            Console.WriteLine("Cloned student equals {0} after changing test? {1}", test.FirstName, test == clonedStudent);

        }
    }
}
