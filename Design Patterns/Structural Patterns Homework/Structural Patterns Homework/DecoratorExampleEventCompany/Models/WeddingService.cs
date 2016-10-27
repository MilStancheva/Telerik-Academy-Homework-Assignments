using System;
using System.Linq;
using DecoratorExampleEventCompany.Contracts;

namespace DecoratorExampleEventCompany.Models
{
    public class WeddingService : EventService
    {
        public override decimal Cost
        {
            get
            {
                //Service charge for overall management
                return 10000;   
            }
        }
    }
}
