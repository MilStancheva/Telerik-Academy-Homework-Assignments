namespace CompositeDesignPatternExampleCompany.Contracts
{
    public interface ITask
    {
        bool IsFinished { get; set; }

        bool IsInProgress { get; set; }

        string Display();
    }
}