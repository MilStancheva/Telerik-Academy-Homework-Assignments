using System;
using System.Linq;

namespace SimpleFactoryExampleComputerFactory
{
    public class HPComputer : Computer
    {
        private const string ManufacturerName = "HP";
        private string model = "Pavilion";

        public HPComputer() 
            : base()
        {
            
        }

        public override string Manufacturer
        {
            get
            {
                return ManufacturerName;
            }
        }

        public override string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }
    }
}
