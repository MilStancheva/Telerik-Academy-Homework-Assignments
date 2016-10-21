using System;
using System.Linq;

namespace FactoryMethodExampleTomatoes
{
    public class GreekTomato : ITomato
    {
        private string sort;

        public GreekTomato()
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
            return " from Greece";
        }
    }
}
