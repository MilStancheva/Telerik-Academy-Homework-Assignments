using System;

namespace NorthwindDb
{
    public class StartUp
    {
        public static void Main()
        {   
            //Task 1 - test        
            var newCustomer = new Customer()
            {
                CustomerID = "pesho",
                CompanyName = "NewCompany",
                ContactName = "Peter Petrov",
                ContactTitle = "Marketing Manager",
                City = "Sofia",
                Country = "Bulgaria"
            };

            CustomersFunctionality.InsertCustomer(newCustomer);
            Console.WriteLine($"Customer {newCustomer.CompanyName} added to database");

            var id = "pesho";
            var pesho = CustomersFunctionality.GetCustomerById(id);
            Console.WriteLine($"Contact name of customer: {pesho.ContactName}");

            CustomersFunctionality.ModifyCustomerCompanyName(newCustomer, "New Company Enterprises");
            Console.WriteLine($"Company name of {newCustomer.CompanyName} is changed");
   
            CustomersFunctionality.ModifyCustomerCompanyNameById(id, "The Company Enterprises");
            Console.WriteLine($"Company name of {newCustomer.CompanyName} is modified");

            CustomersFunctionality.DeleteCustomerById(id);
            Console.WriteLine($"Customer with id '{id}' is deleted");

            //Task 3 - test
            var customers = CustomersFunctionality.GetCustomersWithOrdersIn1997ToCanada();
            Console.WriteLine("Result from task 3 - all customers who have orders made in 1997 and shipped to Canada:");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CompanyName);
            }
            Console.WriteLine();

            //Task 4 - test
            var customersGotWithSqlQuery = CustomersFunctionality.GetCustomersWithOrdersIn1997ToCanadaBySqlQuery();
            Console.WriteLine("Result from task 4 - all customers who have orders made in 1997 and shipped to Canada with ative SQL query:");

            foreach (var cust in customersGotWithSqlQuery)
            {
                Console.WriteLine(cust);
            }
            Console.WriteLine();

            //Task 5 - test
            var orders = CustomersFunctionality.GetOrdersByRegionAndPeriod("Québec", DateTime.Parse("1996-10-20"), DateTime.Parse("1998-10-20"));
            foreach (var order in orders)
            {
                Console.WriteLine(order.OrderDate);
            }

            //task 7 Try to open two different data contexts and perform concurrent changes on the same records.
            //What will happen at SaveChanges()?  - the second context overrites the previous saved data. 
            //The contexts are two - the first one is created in the methods themselves and the second one is secondbContext here in the Main method.

            var secondDbContext = new NorthwindEntities();
            var goshoId = "gosho";

            using (secondDbContext)
            {
                var secondCustomer = new Customer()
                {
                    CustomerID = "gosho",
                    CompanyName = "Gosho Company",
                    ContactName = "George Georgiev",
                    ContactTitle = "Marketing Manager",
                    City = "Sofia",
                    Country = "Bulgaria"
                };

                CustomersFunctionality.InsertCustomer(secondCustomer);
                Console.WriteLine($"Customer {secondCustomer.CompanyName} added to database");

                CustomersFunctionality.ModifyCustomerCompanyName(secondCustomer, "New Gosho Company Enterprises");
                Console.WriteLine($"Company name of {secondCustomer.CompanyName} is changed");

                CustomersFunctionality.ModifyCustomerCompanyNameById(goshoId, "The Gosho Company Enterprises");
                Console.WriteLine($"Company name of {secondCustomer.CompanyName} is modified");

                CustomersFunctionality.DeleteCustomerById(goshoId);
                Console.WriteLine($"Customer with id '{goshoId}' is deleted");

                secondDbContext.SaveChanges();
            }


            //Task 8 - test 
            var dbContext = new NorthwindEntities();
            using (dbContext)
            {
                var employee = dbContext.Employees.Find(3);

                foreach (var territory in employee.TerritoriesSet)
                {
                    Console.WriteLine($"TerritoryId in Employee's territory set: {territory.TerritoryID}");
                }
            }
        }
    }
}
