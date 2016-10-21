using System;
using System.Linq;

namespace FactoryMethodExampleTomatoes
{
    public class DefaultTomato : ITomato
    {
        private string sort;

        public DefaultTomato()
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
            return " not available";
        }
    }
}
