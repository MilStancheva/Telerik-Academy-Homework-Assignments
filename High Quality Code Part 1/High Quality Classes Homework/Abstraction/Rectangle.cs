using System;
using Abstraction.Contracts;

namespace Abstraction
{
    public class Rectangle : Figure, IRectangle, IFigure
    {
        private string InvalidWidthExceptionMessage = "Width should be a non negative number.";
        private string InvalidHeightExceptionMessage = "Height should be a non negative number.";
        private double width;
        private double height;        

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidWidthExceptionMessage);
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidHeightExceptionMessage);
                }

                this.height = value;
            }
        }       

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
