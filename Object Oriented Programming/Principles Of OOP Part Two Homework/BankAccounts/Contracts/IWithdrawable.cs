namespace BankAccounts.Contracts
{
    public interface IWithdrawable
    {
        void WithdrawMoney(decimal amount);
    }
}