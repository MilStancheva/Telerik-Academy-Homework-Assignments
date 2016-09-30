namespace BankAccounts.Models
{
    using Accounts;
    using Customers;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Bank
    {
        private string name;
        private List<Customer> customers;
        private List<Account> accounts;

        public Bank(string name, List<Customer> customers, List<Account> accounts)
        {
            this.customers = new List<Customer>();
            foreach (var customer in customers)
            {
                this.customers.Add(customer);
            }
            this.accounts = new List<Account>();
            foreach (var account in accounts)
            {
                this.accounts.Add(account);
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The bank has to have a name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return new List<Customer>(this.customers);
            }
            private set
            {
                this.customers = value;
            }
        }

        public List<Account> Accounts
        {
            get
            {
                return new List<Account>(this.accounts);
            }
            private set
            {
                this.accounts = value;
            }
        }

        public void AddCustomer(Customer customer)
        {
            this.customers.Add(customer);
        }

        public void RemoveCustomer (Customer customer)
        {
            this.customers.Remove(customer);
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            this.accounts.Remove(account);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("Name of bank: {0}", this.Name));
            builder.AppendLine(string.Format("Customers {0}", string.Join(",", this.Customers)));
            return builder.ToString();
        }
    }
}