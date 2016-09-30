namespace BankAccounts.Models.Customers
{
    using Accounts;
    using System;
    using System.Collections.Generic;

    public abstract class Customer
    {
        private string name;
        private string customerID;
        private List<Account> accounts;
        
        public Customer(string name, string customerID, List<Account> accounts)
        {
            this.accounts = new List<Account>();
            foreach (var account in accounts)
            {
                this.accounts.Add(account);
            }
        }

        public Customer(string name, string customerID)
        {
            this.name = name;
            this.customerID = customerID;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please fill in the name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string CustomerID
        {
            get
            {
                return this.customerID;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("CustomerID should be generated.");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Name, this.CustomerID); 
        }
    }
}