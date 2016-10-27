using System;
using System.Linq;

namespace CompositeDesignPatternExampleCompany.Contracts
{
    public interface IEmployeeComponent
    {
        bool GetDone(ITask task);

        string Display();
    }
}
