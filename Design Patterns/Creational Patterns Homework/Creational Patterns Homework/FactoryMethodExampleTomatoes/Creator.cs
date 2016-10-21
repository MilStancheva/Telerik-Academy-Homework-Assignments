using System;
using System.Linq;

namespace FactoryMethodExampleTomatoes
{
    public class Creator
    {
        public ITomato FactoryMethod(int month)
        {
            if (month >= 4 && month <= 11)
            {
                return new PolishTomato();
            }
            else if (month == 12 || month == 1 || month == 2)
            {
                return new GreekTomato();
            }
            else
            {
                return new DefaultTomato();
            }
        }
    }
}
