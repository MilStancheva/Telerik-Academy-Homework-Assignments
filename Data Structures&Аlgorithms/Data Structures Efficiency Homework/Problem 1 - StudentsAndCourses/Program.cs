using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Problem_1___StudentsAndCourses
{
    public class Program
    {
        public static void Main()
        {
            var path = @"../../students.txt";
            var courses = GetCoursesFromFileText(path);
            PrintCoursesOnConsole(courses);
        }

        private static IDictionary<string, SortedDictionary<string, string>> GetCoursesFromFileText(string path)
        {
            var courses = new SortedDictionary<string, SortedDictionary<string, string>>();

            var reader = new StreamReader(path);
            var line = string.Empty;

            while ((line = reader.ReadLine()) != null)
            {
                var lineParts = line.Split(new char[] { ',', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var firstName = lineParts[0];
                var lastName = lineParts[1];
                var course = lineParts[2];

                if (courses.ContainsKey(course))
                {
                    courses[course].Add(lastName, firstName);
                }
                else
                {
                    courses.Add(course, new SortedDictionary<string, string>());
                    courses[course].Add(lastName, firstName);
                }
            }

            reader.Close();
            return courses;
        }

        private static void PrintCoursesOnConsole(IDictionary<string, SortedDictionary<string, string>> courses)
        {
            var builder = new StringBuilder();
            foreach (var course in courses)
            {
                builder.Append(course.Key + " - ");
                foreach (var name in course.Value)
                {
                    builder.Append(name.Value + " " + name.Key);
                    builder.Append(", ");
                }

                builder.Append(Environment.NewLine);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}