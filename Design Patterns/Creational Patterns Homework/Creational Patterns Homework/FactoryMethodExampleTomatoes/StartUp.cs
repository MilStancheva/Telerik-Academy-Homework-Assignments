using System;
using System.Linq;

namespace FactoryMethodExampleTomatoes
{
    public class StartUp
    {
        public static void Main()
        {
            var creator = new Creator();
            ITomato tomato;

            for (int i = 1; i <= 12; i++)
            {
                tomato = creator.FactoryMethod(i);
                Console.WriteLine("Tomato" + tomato.ShipFrom());
            }
        }
    }
}
