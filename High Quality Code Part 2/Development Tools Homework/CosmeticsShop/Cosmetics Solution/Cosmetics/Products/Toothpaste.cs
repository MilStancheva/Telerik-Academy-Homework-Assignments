namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    /// <summary>
    /// Toothpaste class represents the features of the toothpase type in the Cosmetics shop application.
    /// </summary>
    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private const int MinLengthIngredient = 4;
        private const int MaxLengthIngredient = 12;

        private readonly IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ValidateIngredients(ingredients);
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get { return string.Join(", ", this.ingredients); }
        }

        /// <summary>
        /// Prints the toothpaste.
        /// </summary>
        /// <returns>Returns a string value.</returns>
        public override string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(base.Print());
            result.Append(string.Format("  * Ingredients: {0}", this.Ingredients));
            return result.ToString();
        }

        private void ValidateIngredients(IList<string> ingredients)
        {
            foreach (var ingredient in this.ingredients)
            {
                if (ingredient.Length < MinLengthIngredient || ingredient.Length > MaxLengthIngredient)
                {
                    throw new IndexOutOfRangeException(string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", MinLengthIngredient, MaxLengthIngredient));
                }
            }
        }
    }
}
