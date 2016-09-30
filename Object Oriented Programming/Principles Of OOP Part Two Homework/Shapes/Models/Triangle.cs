namespace Shapes.Models
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }
    }
}