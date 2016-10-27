using System;
using System.Collections.Generic;
using System.Linq;
using AdapterExampleShoppingPortal.Contracts;

namespace AdapterExampleShoppingPortal.Models
{
    public class VendorAdapter : ITarget
    {
        public List<string> GetProducts()
        {
            VendorAdaptee adaptee = new VendorAdaptee();
            return adaptee.GetListOfProducts();
        }
    }
}
