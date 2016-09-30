
namespace _02.StudentsAndWorkers
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartUp
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Peter", "Ivanov", 6),
                new Student("Maria", "Petrova", 4),
                new Student("Kaloyan", "Georgiev", 5),
                new Student("Evgeniya", "Pesheva", 3),
                new Student("Boris", "Kolev", 6),
                new Student("Nikolina", "Lozanova", 6),
                new Student("Valentina", "Ormanova", 2),
                new Student("Zlatomir", "Spasov", 4),
                new Student("Yavor", "Vasilev", 3),
                new Student("Radoslava", "Yoncheva", 5)
        };

            var sortedStudents = from student in students
                                 orderby student.Grade
                                 select student;

            Console.WriteLine("Students sorted by grade:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("------------------------------------------------");

            var workers = new List<Worker>()
            {
                new Worker("Georgi", "Dimitrov", 500, 6),
                new Worker("Anna", "Marinova", 700, 8),
                new Worker("Ralica", "Ivanova", 400, 5),
                new Worker("Simeon", "Simeonov", 540, 6),
                new Worker("Antoniya", "Geshova", 355, 8),
                new Worker("Ivan", "Nikolov", 520, 7),
                new Worker("Niya", "Koliova", 630, 6),
                new Worker("Stoyan", "Nikolov", 488, 7),
                new Worker("Boyana", "Ircheva", 780, 10),
                new Worker("Anton", "Antonov", 760, 8)
        };

            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());

            Console.WriteLine("Workers sorted by money per hour:");
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine("------------------------------------------------");

            var mergedStudentsAndWorkers = new List<Human>();
            mergedStudentsAndWorkers.AddRange(students);
            mergedStudentsAndWorkers.AddRange(workers);

            var sortedMergedStudentsAndWorkers = mergedStudentsAndWorkers.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            Console.WriteLine("Sorted merged Students and Workers:");
            foreach (var human in sortedMergedStudentsAndWorkers)
            {
                Console.WriteLine(human);
            }
        }
    }
}