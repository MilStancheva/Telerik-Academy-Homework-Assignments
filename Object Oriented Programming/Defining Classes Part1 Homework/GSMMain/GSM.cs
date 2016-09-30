namespace GSMMain
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        //Problem 1. Problem 1. Define class
        //Define a class that holds information about a mobile phone device: model, manufacturer, 
        //price, owner, battery characteristics(model, hours idle and hours talk) and display characteristics
        //(size and number of colors).
        //Define 3 separate classes(class GSM holding instances of the classes Battery and Display).

        #region GSMFields

        //Problem 6. Static field
        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

        private static GSM iPhone4S;

        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory; //problem 9

        #endregion

        //Problem 2 - Define several constructors for the defined classes that take different sets of arguments 
        //(the full information for the class or part of it).
        //Assume that model and manufacturer are mandatory(the others are optional). All unknown data fill with null.

        #region GSMConstructors

        static GSM()
        {
            IPhone4S = new GSM("Apple", "4S", 1509.99, "Steve Jobs", new Battery("light", 200, 15, BatteryType.LiIon), new Display(4.5, 16000000), null);
        }

        public GSM(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        public GSM(string manufacturer, string model, double price = 0, string owner = null, Battery battery = null, Display display = null, List<Call> callHistory = null)
            : this(manufacturer, model)
        {

            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = new List<Call>();//problem 9
        }

        #endregion

        //Problem 5. Properties
        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.

        #region GSMProperties

        #region Static Properties
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            private set { iPhone4S = value; }
        }

        #endregion

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        } //problem 9

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("The model should have more than 0 characters");
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Please set the manufacturer. String should not be empty.");
                this.manufacturer = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price should be bigger than 0.");
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Please set the owner.");
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            private set { this.display = value; }
        }

        #endregion

        #region Methods

        // Problem 4. ToString
        // Add a method in the GSM class for displaying all information about it. Try to override ToString().

        public override string ToString()
        {
            var fullInformation = new StringBuilder();
            fullInformation.Append("Manufacturer: " + this.Manufacturer.ToString() + Environment.NewLine);
            fullInformation.Append("Model: " + this.Model.ToString() + Environment.NewLine);
            fullInformation.Append("Owner: " + this.Owner.ToString() + Environment.NewLine);
            fullInformation.Append("Price: " + this.Price.ToString() + Environment.NewLine);
            fullInformation.Append("Battery: " + this.Battery.ToString() + Environment.NewLine);
            fullInformation.Append("Display: " + this.Display.ToString() + Environment.NewLine);

            return fullInformation.ToString();
        }

        //Problem 10. Add/Delete calls
        //Add methods in the GSM class for adding and deleting calls from the calls history.
        //Add a method to clear the call history.

        public List<Call> AddCall (Call call)
        {
            this.CallHistory.Add(call);
            return new List<Call>(this.CallHistory);
        }

        public List<Call> DeleteCall (Call call)
        {
            this.CallHistory.Remove(call);
            return new List<Call>(this.CallHistory);
        }

        public List<Call> ClearHistory ()
        {
            this.CallHistory.Clear();
            return new List<Call>(this.CallHistory);
        }

        //Problem 11. Call price
        //Add a method that calculates the total price of the calls in the call history.
        //Assume the price per minute is fixed and is provided as a parameter.

        public decimal CaculateTotalCallPrice (decimal price)
        {
            int totalDuration = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += callHistory[i].Duration;
            }

            decimal totalPrice = totalDuration* (price/60);

            return totalPrice;
        }

        public string PrintCallHistory()
        {
            return string.Format("Calls history:\n{0}", string.Join(Environment.NewLine, new List<Call>(this.callHistory)).ToString());
        }

      
        #endregion
    }
}
