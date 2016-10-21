using System;
using System.Linq;

namespace FactoryWithReflectionExampleComputers
{
    public class HPComputer : Computer, IComputer
    {
        private const string ManufacturerName = "HP";
        private string ModelName = "Pavilion";

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
                return ModelName;
            }
        }
    }
}
