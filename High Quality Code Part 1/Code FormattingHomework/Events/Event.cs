using System;
using System.Text;

namespace Events
{
    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int eventsOrderedByDate = this.date.CompareTo(other.date);
            int eventsOrderedByTitle = this.title.CompareTo(other.title);
            int eventsOrderedByLocation = this.location.CompareTo(other.location);

            if (eventsOrderedByDate == 0)
            {
                if (eventsOrderedByTitle == 0)
                {
                    return eventsOrderedByLocation;
                }
                else
                {
                    return eventsOrderedByTitle;
                }
            }
            else
            {
                return eventsOrderedByDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (this.location != null && this.location != string.Empty)
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}
