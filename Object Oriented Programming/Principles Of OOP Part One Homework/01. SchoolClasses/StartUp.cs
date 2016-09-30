namespace _01.SchoolClasses
{
    using Infrastructure.Enumerations;
    using Models;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            Student firstStudent = new Student("Pesho", 1);
            Student secondStudent = new Student("Gosho", 2);

            students.Add(firstStudent);
            students.Add(secondStudent);

            Console.WriteLine("Students: {0}", string.Join(", ", students));

            firstStudent.Comment = "Hello sunshine!";
            Console.WriteLine("{0} comments: {1}", firstStudent.Name, firstStudent.Comment);
            Console.WriteLine("-----------------------------------------");
            
            var ivanovsDisciplines = new List<Discipline>();
            ivanovsDisciplines.Add(new Discipline(DisciplineType.Mathemathics));
            ivanovsDisciplines.Add(new Discipline(DisciplineType.Physics));
            Teacher ivanovTeacher = new Teacher("Gospodin Ivanov", ivanovsDisciplines);
            ivanovTeacher.Comment = "Pesho and Gosho, stand up and stay calm!";

            var petrovaDisciplines = new List<Discipline>();
            petrovaDisciplines.Add(new Discipline(DisciplineType.Geography));
            petrovaDisciplines.Add(new Discipline(DisciplineType.Chemistry));
            Teacher petrovaTeacher = new Teacher("Gospoja Petrova", petrovaDisciplines);

            Console.WriteLine("{0}", ivanovTeacher);
            Console.WriteLine("{0}", petrovaTeacher);
            Console.WriteLine("Gospodin Ivanov comments: {0}", ivanovTeacher.Comment);

            var setOfTeachers = new List<Teacher>();
            setOfTeachers.Add(ivanovTeacher);
            setOfTeachers.Add(petrovaTeacher);
            Console.WriteLine("-------------------------------------------");
            //School class
            SchoolClass firstClass = new SchoolClass("A", setOfTeachers, students);

            Console.WriteLine(firstClass);

            firstClass.AddStudent(new Student("Gesha", 3));
            firstClass.RemoveTeacher(petrovaTeacher);

            Console.WriteLine(firstClass);
        }
    }
}