using System;
using System.Collections.Generic;
using System.Linq;
using CompositeDesignPatternExampleCompany.Contracts;

namespace CompositeDesignPatternExampleCompany
{
    public class StartUp
    {
        public static void Main()
        {
            var pesho = new Employee("Peter Petrov");
            var gosho = new Employee("George Georgiev");
            var nadia = new Employee("Nadia Petkova");

            var ivan = new Manager("Ivan Ivanov", new List<IEmployeeComponent> { pesho, gosho});
            var ani = new Manager("Ani Pavlova", new List<IEmployeeComponent> { ivan, nadia });

            ivan.AddNewEmployeeInTeam(new Employee("Maria Marinova"));
            ivan.RemoveEmployeeFromTeam(pesho);

            Console.WriteLine(ivan.Display());
            Console.WriteLine(ani.Display());
        }
    }
}
