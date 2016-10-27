using System;
using System.Linq;

namespace DecoratorExampleEventCompany.Contracts
{
    public abstract class EventServiceDecorator : EventService
    {
        private IEventService eventServiceObj;
        
        public EventServiceDecorator(IEventService eventService)
        {
            this.eventServiceObj = eventService;
        }

        public override decimal Cost
        {
            get
            {
                return eventServiceObj.Cost;
            }
        }
    }
}
