namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    /// <summary>
    /// The shopping cart represents the ShoppingCart type.
    /// </summary>
    public class ShoppingCart : IShoppingCart
    {
        private readonly IList<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        /// <summary>
        /// Adds a product to the shopping cart.
        /// </summary>
        /// <param name="product">The product to be added.</param>
        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product to add to cart"));
            this.products.Add(product);
        }

        /// <summary>
        /// Removes a product from the shopping cart.
        /// </summary>
        /// <param name="product">The product to be removed.</param>
        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product to remove from cart"));
            this.products.Remove(product);
        }

        /// <summary>
        /// Checks if a product is already in the shopping cart.
        /// </summary>
        /// <param name="product">The product to be checked.</param>
        /// <returns>Returns a boolean value.</returns>
        public bool ContainsProduct(IProduct product)
        {
            return this.products.Contains(product);
        }

        /// <summary>
        /// calculates the total sum of the products in the shopping cart.
        /// </summary>
        /// <returns>Returns a decimal value.</returns>
        public decimal TotalPrice()
        {
            return this.products.Sum(pr => pr.Price);
        }
    }
}
