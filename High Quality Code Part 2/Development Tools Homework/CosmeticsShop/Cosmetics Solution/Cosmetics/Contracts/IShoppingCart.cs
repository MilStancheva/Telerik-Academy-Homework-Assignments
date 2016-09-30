namespace Cosmetics.Contracts
{
    /// <summary>
    /// IShoppingCart is a contract for the Shopping cart class.
    /// </summary>
    public interface IShoppingCart
    {
        void AddProduct(IProduct product);

        void RemoveProduct(IProduct product);

        bool ContainsProduct(IProduct product);

        decimal TotalPrice();
    }
}
