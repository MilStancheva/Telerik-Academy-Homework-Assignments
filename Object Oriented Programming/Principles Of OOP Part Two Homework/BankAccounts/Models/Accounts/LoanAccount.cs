namespace BankAccounts.Models.Accounts
{
    using Customers;
    using Contracts;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interestAmount = 0m;

            if ( this.Customer is Individual)
            {
                interestAmount = (this.InteresetRate * (months - 3));
            }
            else if (this.Customer is Company)
            {
                interestAmount = (this.InteresetRate * (months - 2m));
            }
            return interestAmount;
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}