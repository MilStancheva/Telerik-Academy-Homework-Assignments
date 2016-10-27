using System;
using System.Linq;

namespace CompositeDesignPatternExampleCompany.Contracts
{
    public abstract class EmployeeComponent : IEmployeeComponent
    {
        protected string name;

        public EmployeeComponent(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                this.name = value;
            }
        }

        public abstract string Display();

        public abstract bool GetDone(ITask task);
    }
}
