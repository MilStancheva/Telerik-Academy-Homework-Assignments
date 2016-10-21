using System;
using System.Linq;

namespace FactoryWithReflectionExampleComputers
{
    public abstract class Computer : IComputer
    {
        protected Computer()
        {
            this.SerialNumber = Guid.NewGuid();
        }

        public abstract string Manufacturer { get; }

        public abstract string Model { get; }

        public virtual Guid SerialNumber { get; private set; }


        public override string ToString()
        {
            return $"{this.SerialNumber} - {this.Manufacturer} - {this.Model}";
        }
    }
}
