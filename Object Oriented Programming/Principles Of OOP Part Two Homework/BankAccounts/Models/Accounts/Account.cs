namespace BankAccounts.Models.Accounts
{
    using Contracts;
    using Customers;
    using System.Text;

    public abstract class Account: IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InteresetRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                this.interestRate = value;
            }
        }

        public abstract decimal CalculateInterest(int months);

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Account:");
            builder.AppendLine(string.Format("{0}", this.Customer));
            builder.AppendLine(string.Format("Balance: {0} BGN", this.Balance));
            builder.AppendLine(string.Format("Monthly interest rate: {0}%", this.InteresetRate));

            return builder.ToString();
        }
    }
}