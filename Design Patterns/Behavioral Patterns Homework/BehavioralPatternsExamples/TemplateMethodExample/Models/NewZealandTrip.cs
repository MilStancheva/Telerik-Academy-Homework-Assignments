using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodExampleTravelAgency.Infrastructure;

namespace TemplateMethodExampleTravelAgency.Models
{
    public class NewZealandTrip : Trip
    {
        private const string NZLocation = "Wellington";
        private const ActivityType ActivityInNZ = ActivityType.NatureExploration;
        private const TransportType TransportToNZ = TransportType.Ship;
        private const AccommodationType AccommodationInNZ = AccommodationType.ThreeStarHotel;

        public NewZealandTrip() 
            : base(TransportToNZ, AccommodationInNZ, ActivityInNZ, NZLocation)
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
