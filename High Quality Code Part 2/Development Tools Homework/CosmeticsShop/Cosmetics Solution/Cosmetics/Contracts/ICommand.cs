namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// ICommand interface is a contract for using the commands of the application.
    /// </summary>
    public interface ICommand
    {
        string Name { get; }

        IList<string> Parameters { get; }
    }
}
