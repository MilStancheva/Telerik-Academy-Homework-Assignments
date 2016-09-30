namespace GSMMain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        #region DisplayFields

        private double size;
        private int colorsCount;

        #endregion

        #region DisplayConstructors

        //Empty constructor setting the default values of the GSM (for example - size 4.0 & number of colors - 256.
        public Display() : this(4.0, 256)
        {

        }

        //Constructor taking only the size and setting the default number of colors 256. 
        public Display(double size):this(size, 256)
        {
       
        }

        //Constructor taking both the size & the number of colors.
        public Display(double size, int colorsCount)
        {
            this.size = size;
            this.colorsCount = colorsCount;
        }

        #endregion

        //Problem 5. Properties
        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
        //Ensure all fields hold correct data at any given time.

        #region DisplayProperties

        public double Size
        {
            get { return this.size; }
            set
            {
                if (value <= 0 || value > 8)
                    throw new ArgumentOutOfRangeException("Size should be positive and less than 10!");
                this.size = value;
            }
        }

        public int ColorsCount
        {
            get { return this.colorsCount; }
            set
            {
                if (value <= 255 || value > int.MaxValue)
                    throw new ArgumentOutOfRangeException("The number of the colors should be bigger than 255 and less than int.MaxValue!");
                this.colorsCount = value;
            }
        }
        #endregion

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append("Size - ");
            output.Append($"{this.Size}; ");
            output.Append("Colors - ");
            output.Append($"{this.ColorsCount}");
            
            return output.ToString();
        }
    }
}
