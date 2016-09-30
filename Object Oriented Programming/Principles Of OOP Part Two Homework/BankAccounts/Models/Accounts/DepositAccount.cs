namespace BankAccounts.Models.Accounts
{
    using System;
    using Customers;
    using Contracts;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                Console.WriteLine("In order to have an intereset payment the account balance should be at least 1000.");
                return 0;
            }
            else
            {
                return months * this.InteresetRate;
            }
        }

        public void WithdrawMoney(decimal amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("Insufficient balance to withdrawal.");
            }
            else
            {
                this.Balance -= amount;

            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}