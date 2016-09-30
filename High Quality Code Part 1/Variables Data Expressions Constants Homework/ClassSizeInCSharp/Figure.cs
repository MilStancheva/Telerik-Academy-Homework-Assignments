using System;

namespace ClassSizeInCSharp
{
    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double heigth)
        {
            this.width = width;
            this.height = heigth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative");
                }

                this.width = value;
            }
        }

        public double Heigth
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be negative");
                }

                this.height = value;
            }
        }

        public static Figure GetRotatedFigure(Figure figure, double angleOfTheFigureToBeRotated)
        {
            double sinusTimesWidth = Math.Abs(Math.Sin(angleOfTheFigureToBeRotated)) * figure.Width;
            double cosinusTimesWidth = Math.Abs(Math.Cos(angleOfTheFigureToBeRotated)) * figure.Width;
            double sinusTimesHeight = Math.Abs(Math.Sin(angleOfTheFigureToBeRotated)) * figure.Heigth;
            double cosinusTimesHeight = Math.Abs(Math.Cos(angleOfTheFigureToBeRotated)) * figure.Heigth;

            double rotatedFigureWidth = sinusTimesWidth + cosinusTimesWidth;
            double rotatedFigureHeigth = sinusTimesHeight + cosinusTimesHeight;

            Figure rotatedFigure = new Figure(rotatedFigureWidth, rotatedFigureHeigth);

            return rotatedFigure;
        }

        /// <summary>
        /// ToString methos is overriden to print the figure's width and heigth.
        /// </summary>
        /// <returns>a string value</returns>
        public override string ToString()
        {
            return string.Format("({0:F2}, {1:F2})", this.Width, this.Heigth);
        }
    }
}
