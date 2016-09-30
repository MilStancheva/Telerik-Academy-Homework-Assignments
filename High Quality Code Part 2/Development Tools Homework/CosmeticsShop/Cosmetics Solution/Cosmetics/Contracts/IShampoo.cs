namespace Cosmetics.Contracts
{
    using Cosmetics.Common;

    /// <summary>
    /// IShampoo is a contract for the Shampoo class of the Cosmetics shop application. 
    /// </summary>
    public interface IShampoo : IProduct
    {
        uint Milliliters { get; }

        UsageType Usage { get; }
    }
}