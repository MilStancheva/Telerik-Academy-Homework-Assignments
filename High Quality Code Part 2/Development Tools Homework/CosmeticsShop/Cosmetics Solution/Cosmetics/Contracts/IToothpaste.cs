namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// IToothpaste is a contract for the Toothpaste class.
    /// </summary>
    public interface IToothpaste : IProduct
    {
        string Ingredients { get; }
    }
}