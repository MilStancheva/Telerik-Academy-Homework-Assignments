using System;
using System.Linq;

namespace FactoryMethodExampleTomatoes
{
    public interface ITomato
    {
        string Sort { get; set; }

        string ShipFrom();
    }
}
