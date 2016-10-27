using System;
using System.Linq;
using DecoratorExampleEventCompany.Contracts;

namespace DecoratorExampleEventCompany.Models
{
    public class CateringService : EventServiceDecorator
    {
        public CateringService(IEventService eventService)
            : base(eventService)
        {

        }

        public override decimal Cost
        {
            get
            {
                //Cost of whatever event service represented by EventService + Catering service
                return base.Cost + 50000;
            }
        }
    }
}
