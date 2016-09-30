namespace BankAccounts
{
    using Models.Accounts;
    using Models.Customers;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var customers = new List<Customer>()
            {
                new Individual("Peter Vasilev", "PV1234"),
                new Individual("Maria Ivanova", "MI6789"),
                new Individual("Geroge Georgiev", "GI9876"),
                new Company("MG Solutions", "MG4568"),
                new Company("GP", "GP7865"),
                new Company("NewHorizons", "NH54320")
            };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("----------------------------------------------");

            //Creating an account data: 

            var accounts = new List<Account>()
            {
                new DepositAccount(new Individual("Petia Georgieva", "PG5678"), 200, 2.5m),
                new LoanAccount(new Company("KartiMivki", "KM6740"), 1000, 1.9m),
                new MortgageAccount(new Individual("Dragomir Ivanov", "DI7654"), 500, 0.3m),
                new DepositAccount(new Company("TerraGroup", "TG986543"), 2500000, 1.5m),
                new LoanAccount(new Individual("Yoana Peshova", "YP675964"), 13000, 1.1m),
                new MortgageAccount(new Company("AppfelSaft", "AS8653829"), 35000, 1.2m)

            };

            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
            Console.WriteLine("----------------------------------------------");

            //new depotit of a Deposit account and calculating the interest payment of an Individual

            Console.WriteLine("Deposit account of {0} BEFORE to make a new deposit: {1}", accounts[0].Customer.Name, accounts[0]);
            accounts[0].DepositMoney(150);
            Console.WriteLine("Deposit account of {0} AFTER to make a new deposit: {1}", accounts[0].Customer.Name, accounts[0]);

            Console.WriteLine("The intereset payment of {0}: {1} BGN", accounts[0].Customer.Name, accounts[0].CalculateInterest(15));
            Console.WriteLine("----------------------------------------------");

            //Check the interest payment of a Company
            Console.WriteLine("The intereset payment of {0}: {1} BGN", accounts[3].Customer.Name, accounts[3].CalculateInterest(15));

            Console.WriteLine("----------------------------------------------");

            //new Withdrawal a Deposit account and calculating the interest payment
            DepositAccount accountOfGeorge = new DepositAccount(customers[2], 3045, 1.5m);
            Console.WriteLine("Deposit account of {0} BEFORE to make a withdrawal: {1}", accountOfGeorge.Customer.Name, accountOfGeorge);
            accountOfGeorge.WithdrawMoney(350);
            Console.WriteLine("Deposit account of {0} AFTER making a withdrawal: {1}", accountOfGeorge.Customer.Name, accountOfGeorge);
           
        }
    }
}