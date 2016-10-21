using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWithReflectionExampleComputers
{
    public interface IComputer
    {
        string Manufacturer { get; }

        string Model { get; }
    }
}
