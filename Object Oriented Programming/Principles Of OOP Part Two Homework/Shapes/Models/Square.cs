namespace Shapes.Models
{
    class Square : Shape
    {
        public Square(double side) : base(side, side)
        {
  
        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width);
        }
    }
}