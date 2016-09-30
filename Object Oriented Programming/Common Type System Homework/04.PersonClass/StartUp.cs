//Problem 4. Person class
//Create a class Person with two fields – name and age.Age can be left unspecified(may contain null value.
//Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

namespace _04.PersonClass
{
    using Models;
    using System;

    public class StartUp
    {
        static void Main()
        {
            Person ivanPerson = new Person("Ivan Petrov");
            Person nellyPerson = new Person("Nelly Ilcheva", 30);

            Console.WriteLine(ivanPerson);
            Console.WriteLine(nellyPerson);
        }
    }
}