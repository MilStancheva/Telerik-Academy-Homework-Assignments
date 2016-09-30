namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    /// <summary>
    /// Category class representing the main features of the categories in the Cosmetics shop application.
    /// </summary>
    public class Category : ICategory
    {
        private const int MinCategoryNameLength = 2;
        private const int MaxCategoryNameLength = 15;
        
        private readonly IList<IProduct> products;
        private string name;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(value, MaxCategoryNameLength, MinCategoryNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinCategoryNameLength, MaxCategoryNameLength));
                this.name = value;
            }
        }

        /// <summary>
        /// Adds a product to the category.
        /// </summary>
        /// <param name="cosmetics">The product to be added</param>
        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to add to category"));
            this.products.Add(cosmetics);
        }

        /// <summary>
        /// Removes a product from the category. 
        /// </summary>
        /// <param name="cosmetics">A cosmetics to be removed.</param>
        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to remove from category"));
            if (!this.products.Contains(cosmetics))
            {
                throw new InvalidOperationException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }

            this.products.Remove(cosmetics);
        }

        /// <summary>
        /// Prining the Categories and the products in it. 
        /// </summary>
        /// <returns>Returns a string type report.</returns>
        public string Print()
        {
            var categoryString = string.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, this.products.Count != 1 ? "products" : "product");

            var result = new StringBuilder();
            result.AppendLine(categoryString);

            var sortedProducts =
                this.products
                    .OrderBy(pr => pr.Brand)
                    .ThenByDescending(pr => pr.Price);

            foreach (var product in sortedProducts)
            {
                result.AppendLine(product.Print());
            }

            return result.ToString().Trim();
        }
    }
}
