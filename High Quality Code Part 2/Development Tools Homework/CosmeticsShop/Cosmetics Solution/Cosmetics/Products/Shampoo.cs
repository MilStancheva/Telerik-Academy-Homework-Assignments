namespace Cosmetics.Products
{
    using System.Text;
    using log4net;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    /// <summary>
    /// Shampoo class representing all features of the shampoo type.
    /// </summary>
    public class Shampoo : Product, IShampoo, IProduct
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Shampoo));

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            Logger.Debug("Hello, someone created a shampoo.");
            this.Milliliters = milliliters;
            this.Usage = usage;
            this.Price *= this.Milliliters;
        }

        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        /// <summary>
        /// Prints the shampoo.
        /// </summary>
        /// <returns>Returns a string value.</returns>
        public override string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(base.Print());
            result.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            result.Append(string.Format("  * Usage: {0}", this.Usage));
            return result.ToString();
        }
    }
}
