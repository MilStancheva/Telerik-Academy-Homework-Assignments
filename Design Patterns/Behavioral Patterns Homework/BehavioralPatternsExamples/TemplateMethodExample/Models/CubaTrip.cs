using System;
using System.Linq;
using TemplateMethodExampleTravelAgency.Infrastructure;

namespace TemplateMethodExampleTravelAgency.Models
{
    public class CubaTrip : Trip
    {
        private const string CubaLocation = "LasTunas";
        private const ActivityType ActivityInCuba = ActivityType.BeachAndLeisure;
        private const TransportType TransportToCuba = TransportType.Plane;
        private const AccommodationType AccommodationInCuba = AccommodationType.PrivateVilla;

        public CubaTrip() 
            : base(TransportToCuba, AccommodationInCuba, ActivityInCuba, CubaLocation)
        {
        }

        public override void DoActivities()
        {
            Console.WriteLine($"Activites for the trip are: {this.Activity}");
        }

        public override void DoCheckInAccommodation()
        {
            Console.WriteLine($"Guests stay at {this.Accommodation}");
        }

        public override void GoBackFromLocation()
        {
            Console.WriteLine($"Return transport is {this.Transport}");
        }

        public override void GoToLocation()
        {
            Console.WriteLine($"Tourists are transported with {this.Transport}");
        }
    }
}
