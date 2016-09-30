using System.Text;
using Abstraction.Contracts;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        protected Figure()
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("I am a " + this.GetType().Name));
            builder.AppendLine(string.Format("My perimeter is {0:F2}.", this.CalculatePerimeter()));
            builder.AppendLine(string.Format("My surface is {0:F2}.", this.CalculateSurface()));

            return builder.ToString();
        }
    }
}
