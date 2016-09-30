//Problem 8. Calls
//Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialled phone number and duration (in seconds).

namespace GSMMain
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Call
    {
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private int duration;

        public Call(DateTime dateAndTime, string dialedPhoneNumber, int duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public override string ToString()
        {
            var callInfo = $"{this.DateAndTime}\t{this.DialedPhoneNumber}\t\t{this.Duration}";
            return callInfo;
        }
    }
}
