using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodExampleTravelAgency.Infrastructure;

namespace TemplateMethodExampleTravelAgency.Models
{
    public abstract class Trip
    {
        private TransportType transport;
        private AccommodationType accommodation;
        private ActivityType activity;
        private string location;

        public Trip(TransportType transport, AccommodationType accommodation, ActivityType activity, string location)
        {
            this.Transport = transport;
            this.Accommodation = accommodation;
            this.Activity = activity;
            this.Location = location;
        }

        public TransportType Transport { get; set; }

        public AccommodationType Accommodation { get; set; }

        public ActivityType Activity { get; set; }

        public string Location { get; set; }

        public abstract void GoToLocation();

        public abstract void DoCheckInAccommodation();

        public abstract void DoActivities();

        public abstract void GoBackFromLocation();

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{this.GetType().Name} to {this.Location}");
            builder.AppendLine($"Includes transport: {this.Transport}");
            builder.AppendLine($"Activities: {this.Activity}");

            return builder.ToString();
        }
    }
}
