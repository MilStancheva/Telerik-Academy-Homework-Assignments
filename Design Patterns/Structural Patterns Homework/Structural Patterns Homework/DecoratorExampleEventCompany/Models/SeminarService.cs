using System;
using System.Linq;
using DecoratorExampleEventCompany.Contracts;

namespace DecoratorExampleEventCompany.Models
{
    public class SeminarService : EventService
    {
        public override decimal Cost
        {
            get
            {
                //Service charge for overall management
                return 5000;   
            }
        }
    }
}
