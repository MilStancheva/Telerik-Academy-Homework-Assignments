using System;
using System.Collections.Generic;
using System.Linq;

namespace AdapterExampleShoppingPortal.Contracts
{
    interface ITarget
    {
        List<string> GetProducts();
    }
}
