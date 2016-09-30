namespace GSMMain
{
    using System;
    using System.Text;
    public class Battery
    {
        #region BatteryFields

        private string batteryModel;
        private int hoursIdle;
        private int hoursTalk;
        BatteryType bateryType;

        #endregion

        #region BatteryCostructors

        //Empty constructor setting default values - model: "Standard", hoursIdle = 200; hoursTalk = 10;
        public Battery() : this("Standard", 200, 10, BatteryType.LiIon)
        {

        }

        //Constructor with 1 parameter - batteryModel; setting the default values of hoursIdle - 200 & hoursTalk - 10;
        public Battery(string batteryModel) :this(batteryModel, 200, 10, BatteryType.LiIon)
        {
            
        }
        //Complete constructor taking 3 parameters - batteryModel, hoursIdle and hoursTalk.
        public Battery(string batteryModel, int hoursIdle, int hoursTalk, BatteryType bateryType)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = bateryType;
        }

        #endregion

        //Problem 5. Properties
        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.

        #region BatteryProperties

        public string BatteryModel
        {
            get { return this.batteryModel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();

                this.batteryModel = value;
            }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The HoursIdle should not be negative!");
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The HoursTalk should not be negative!");
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get { return this.bateryType; }
            set
            {
                this.bateryType = value;
            }
        }

        #endregion

        public override string ToString()
        {
            var output = new StringBuilder();

            output.Append($"Type - {this.BatteryType}; ");
            output.Append($" Hours Talk - {this.HoursTalk};");
            output.Append($" Hours Idle - {this.hoursIdle}");

            return output.ToString();
        }
    }
}
