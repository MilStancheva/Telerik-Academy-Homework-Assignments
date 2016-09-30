namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    using Cosmetics.Common;

    /// <summary>
    /// ICosmetics Factory is a contract for creating the Cosmetics factory class of the Cosmetics shop application.
    /// </summary>
    public interface ICosmeticsFactory
    {
        ICategory CreateCategory(string name);

        IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage);

        IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients);

        IShoppingCart ShoppingCart();
    }
}
