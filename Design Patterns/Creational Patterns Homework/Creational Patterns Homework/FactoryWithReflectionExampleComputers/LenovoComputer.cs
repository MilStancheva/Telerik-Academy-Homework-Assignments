using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryWithReflectionExampleComputers
{
    public class LenovoComputer : Computer, IComputer
    {
        private const string ManufacturerName = "Lenovo";
        private string ModelName = "YogaBook";

        public LenovoComputer()
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
