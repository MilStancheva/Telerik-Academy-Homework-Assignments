using System;
using System.Linq;

namespace SimpleFactoryExampleComputerFactory
{
    public class StartUp
    {
        public static void Main()
        {
            var hpFactory = new HPComputerFactory();

            var firstHPComputer = hpFactory.GetComputer();
            Console.WriteLine(firstHPComputer);

            var secondHPComputer = hpFactory.GetComputer();
            Console.WriteLine(secondHPComputer);
        }
    }
}
