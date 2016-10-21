using System;
using System.Linq;

namespace SimpleFactoryExampleComputerFactory
{
    public abstract class Computer
    {
        protected Computer()
        {
            this.SerialNumber = Guid.NewGuid();
        }

        public abstract string Manufacturer { get; }

        public abstract string Model { get; set; }

        public virtual Guid SerialNumber { get; private set; }


        public override string ToString()
        {
            return $"{this.SerialNumber} - {this.Manufacturer} - {this.Model}";
        }
    }
}
