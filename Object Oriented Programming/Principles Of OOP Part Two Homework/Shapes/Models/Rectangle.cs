namespace Shapes.Models
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return (this.Width * this.Height);
        }
    }
}