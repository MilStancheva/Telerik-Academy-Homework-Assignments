using System;
using System.Linq;
using CompositeDesignPatternExampleCompany.Contracts;

namespace CompositeDesignPatternExampleCompany
{
    public class Employee : EmployeeComponent
    {
        public Employee(string name) 
            : base(name)
        {
        }

        public override bool GetDone(ITask task)
        {
            var result = task.IsFinished;

            return result;
        }

        public override string Display()
        {
            var employeeToDisplay = $"Employee: {this.Name}";

            return employeeToDisplay;
        }

    }
}
