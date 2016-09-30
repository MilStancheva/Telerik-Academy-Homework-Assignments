namespace Shapes.Models
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape (double width, double height)
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
                    throw new ArgumentException("The width of the shape has to be positive.");
                }
                else
                {
                    this.width = value;

                }
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
                if (value <= 0 )
                {
                    throw new ArgumentException("The width of the shape has to be positive.");
                }
                else
                {
                    this.height = value;

                }
            }
        }

        public abstract double CalculateSurface();
    }
}