using System;
using System.Linq;

namespace SimpleFactoryExampleComputerFactory
{
    public abstract class ComputerFactory
    {
        public abstract Computer GetComputer();
    }
}
