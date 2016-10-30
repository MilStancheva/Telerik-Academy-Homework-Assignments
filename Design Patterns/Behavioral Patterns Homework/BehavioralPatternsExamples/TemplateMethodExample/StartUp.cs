using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodExampleTravelAgency.Infrastructure;
using TemplateMethodExampleTravelAgency.Models;

namespace TemplateMethodExample
{
    public class StartUp
    {
        public static void Main()
        {
            var newTripToCuba = new CubaTrip();
            Console.WriteLine(newTripToCuba.ToString());

            var newTripToNewZealand = new NewZealandTrip();
            Console.WriteLine(newTripToNewZealand.ToString());
        }
    }
}
