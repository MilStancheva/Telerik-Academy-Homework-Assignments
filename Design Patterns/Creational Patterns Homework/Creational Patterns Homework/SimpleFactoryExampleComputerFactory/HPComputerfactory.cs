using System;
using System.Linq;

namespace SimpleFactoryExampleComputerFactory
{
    public class HPComputerFactory : ComputerFactory
    {
        public override Computer GetComputer()
        {
            return new HPComputer();
        }
    }
}
