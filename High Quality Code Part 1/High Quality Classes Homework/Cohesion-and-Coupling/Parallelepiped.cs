using System;
using CohesionAndCoupling;

namespace CohesionAndCoupling
{
    public class Parallelepiped
    {
        private string InvalidWidthExceptionMessage = "Width should be bigger than zero.";
        private string InvalidHeightExceptionMessage = "Height should be bigger than zero.";
        private string InvalidDepthExceptionMessage = "Depth should be bigger than zero.";

        private double width;
        private double heigth;
        private double depth;

        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
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
                return this.heigth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidHeightExceptionMessage);
                }

                this.heigth = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidDepthExceptionMessage);
                }

                this.depth = value;
            }
        }         

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;

            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = DimensionalUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);

            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = DimensionalUtils.CalcDistance2D(0, 0, this.Width, this.Height);

            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = DimensionalUtils.CalcDistance2D(0, 0, this.Width, this.Depth);

            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = DimensionalUtils.CalcDistance2D(0, 0, this.Height, this.Depth);

            return distance;
        }
    }
}