using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompositeDesignPatternExampleCompany.Contracts;

namespace CompositeDesignPatternExampleCompany
{
    public class Manager : EmployeeComponent
    {
        private ICollection<IEmployeeComponent> employeesInTheTeam;

        public Manager(string name, ICollection<IEmployeeComponent> employeesInTheTeam) 
            : base(name)
        {
            this.employeesInTheTeam = employeesInTheTeam.ToList();
        }

        public ICollection<IEmployeeComponent> EmployeesInTeam
        {
            get
            {
                return this.employeesInTheTeam;
            }
            set
            {
                this.employeesInTheTeam = value;
            }
        }

        public void AddNewEmployeeInTeam(IEmployeeComponent employee)
        {
            employeesInTheTeam.Add(employee);
        }

        public void RemoveEmployeeFromTeam(IEmployeeComponent employee)
        {
            employeesInTheTeam.Remove(employee);
        }

        public ITask MakeDecisions()
        {
            var decision = new Task();

            return decision;
        }

        public override bool GetDone(ITask task)
        {
            var result = task.IsFinished;

            return result;
        }
        public override string Display()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Manager's name {this.Name}");
            builder.AppendLine($"Employees in the team: ");
            foreach (var employee in this.employeesInTheTeam)
            {
                builder.AppendLine(employee.Display());
            }

            return builder.ToString();
        }
    }
}
