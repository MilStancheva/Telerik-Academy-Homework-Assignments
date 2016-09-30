namespace Cosmetics.Products
{
    using System.Text;
    using log4net;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    /// <summary>
    /// Represents all major features of the product type. 
    /// </summary>
    public abstract class Product : IProduct
    {
        private const int MinBrandLength = 2;
        private const int MinStringLength = 3;
        private const int MaxStringLength = 10;
        private const string ProductName = "Product name";
        private const string ProductBrand = "Product brand";

        private static readonly ILog Logger = LogManager.GetLogger(typeof(Product));

        private string name;
        private string brand;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            Logger.Debug("Hello, a product is called.");
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, ProductName));
                Validator.CheckIfStringLengthIsValid(value, MaxStringLength, MinStringLength, string.Format(GlobalErrorMessages.InvalidStringLength, ProductName, MinStringLength, MaxStringLength));
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, ProductBrand));
                Validator.CheckIfStringLengthIsValid(value, MaxStringLength, MinBrandLength, string.Format(GlobalErrorMessages.InvalidStringLength, ProductBrand, MinBrandLength, MaxStringLength));
                this.brand = value;
            }
        }

        public decimal Price { get; protected set; }

        public GenderType Gender { get; private set; }

        /// <summary>
        /// Prints the product.
        /// </summary>
        /// <returns>Returns a string value.</returns>
        public virtual string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.Append(string.Format("  * For gender: {0}", this.Gender));
            return result.ToString();
        }
    }
}
