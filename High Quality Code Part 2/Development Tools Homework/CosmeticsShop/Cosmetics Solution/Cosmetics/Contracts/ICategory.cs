namespace Cosmetics.Contracts
{
    /// <summary>
    /// ICategory interface represents a contract for the categories in the Cosmetics shop.
    /// </summary>
    public interface ICategory
    {
        string Name { get; }

        void AddCosmetics(IProduct cosmetics);

        void RemoveCosmetics(IProduct cosmetics);

        string Print();
    }
}
