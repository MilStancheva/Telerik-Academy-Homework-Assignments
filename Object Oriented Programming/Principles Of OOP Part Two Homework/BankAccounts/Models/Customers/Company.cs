namespace BankAccounts.Models.Customers
{
    public class Company : Customer
    {
        public Company(string name, string customerID) : base(name, customerID)
        {
            this.Name = name;
            this.CustomerID = customerID;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}