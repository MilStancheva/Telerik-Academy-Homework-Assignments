namespace Cosmetics.Contracts
{
    using Cosmetics.Common;

    /// <summary>
    /// IProduct is a contract for the Product class of the Cosmetics shop application.
    /// </summary>
    public interface IProduct
    {
        string Name { get; }

        string Brand { get; }

        decimal Price { get; }

        GenderType Gender { get; }

        string Print();
    }
}
