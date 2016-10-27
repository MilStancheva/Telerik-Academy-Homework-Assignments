using System;
using System.Linq;
using CompositeDesignPatternExampleCompany.Contracts;

namespace CompositeDesignPatternExampleCompany
{
    public class Task : ITask
    {
        public bool IsFinished { get; set; }
      

        public bool IsInProgress { get; set; }

        public string Display()
        {
            var task = $"Task is in progress: {this.IsInProgress} and is finished: {this.IsFinished}";

            return task;
        }
    }
}
