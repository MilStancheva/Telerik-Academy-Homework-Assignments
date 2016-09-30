namespace BankAccounts.Models.Accounts
{
    using Customers;
    using Contracts;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interestPayment = 0m;
            if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    interestPayment = (this.InteresetRate * months) / 2;
                }
                else
                {
                    interestPayment = (this.InteresetRate * months);
                }
            }
            else if (this.Customer is Individual)
            {
                if (months <= 6)
                {
                    interestPayment = 0;
                }
                else
                {
                    interestPayment = (this.InteresetRate * months);
                }
            }

            return interestPayment;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}