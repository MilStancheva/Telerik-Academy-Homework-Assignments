namespace School.Contracts
{
    using System.Collections.Generic;
    using Models;

    public interface ICourse
    {
        string Name { get; }

        ICollection<IStudent> Students { get; }
    }
}
