using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWithReflectionExampleComputers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var hpType = "HpComputer";
            var lenovoType = "LenovoComputer";
            ComputerFactory.Register<HPComputer>(hpType);
            ComputerFactory.Register<LenovoComputer>(lenovoType);

            var newHpComputer = ComputerFactory.Create<IComputer>(hpType);
            var newLenovoComputer = ComputerFactory.Create<IComputer>(lenovoType);

            Console.WriteLine(newHpComputer);
            Console.WriteLine(newLenovoComputer);
        }
    }
}
