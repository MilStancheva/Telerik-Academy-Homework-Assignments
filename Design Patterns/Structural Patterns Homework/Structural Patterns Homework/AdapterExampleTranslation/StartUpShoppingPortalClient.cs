using System;
using System.Linq;
using AdapterExampleShoppingPortal.Contracts;

namespace AdapterExampleShoppingPortal.Models
{
    public class StartUpShoppingPortalClient
    {
        static void Main(string[] args)
        {
            ITarget adapter = new VendorAdapter();
            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}
