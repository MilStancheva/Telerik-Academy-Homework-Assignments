using System;
using System.Linq;

namespace FactoryMethodExampleTomatoes
{
    public class PolishTomato : ITomato
    {
        private string sort;

        public PolishTomato()
        {
            this.Sort = sort;
        }

        public string Sort
        {
            get
            {
                return this.sort;
            }

            set
            {
                this.sort = value;
            }
        }

        public string ShipFrom()
        {
            return " from Poland";
        }
    }
}
