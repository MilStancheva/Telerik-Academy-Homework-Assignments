using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NorthwindDb
{
    public static class CustomersFunctionality
    {
        /*  Task 1. Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database
            Task 2. Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
        */
        public static void InsertCustomer(Customer newCustomer)
        {
            string customerCannotBeNullExceptionMessage = "Customer to be added cannot be null";

            if (newCustomer == null)
            {
                throw new ArgumentException(customerCannotBeNullExceptionMessage);
            }

            var dbContext = new NorthwindEntities();
            using (dbContext)
            {
                dbContext.Customers.Add(newCustomer);
                dbContext.SaveChanges();
            }

        }

        public static void DeleteCustomerById(string id)
        {
            string customerToBeDeletedNotFoundExceptionMessage = "Customer to be deleted is not found by the provided id";

            var dbContext = new NorthwindEntities();

            var customerToBeDeleted = GetCustomerById(id);

            if (customerToBeDeleted == null)
            {
                throw new InvalidOperationException(customerToBeDeletedNotFoundExceptionMessage);
            }

            using (dbContext)
            {
                //dbContext.Customers.Remove(customerToBeDeleted);
                dbContext.Entry(customerToBeDeleted).State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }

        public static void ModifyCustomerCompanyName(Customer customer, string newCompanyName)
        {
            string customerToBeModifiedCannotBeNullExceptionMessage = "Customer cannot be null. Please, provide a valid one";
            if (customer == null)
            {
                throw new ArgumentException(customerToBeModifiedCannotBeNullExceptionMessage);
            }
            var dbContext = new NorthwindEntities();

            using (dbContext)
            {
                customer.CompanyName = newCompanyName;
                dbContext.Entry(customer).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public static void ModifyCustomerCompanyNameById(string id, string newCompanyName)
        {

            var dbContext = new NorthwindEntities();
            string customerToBeModifiedCannotBeNullExceptionMessage = "Customer id cannot be null. Please, provide a valid one";
            if (id == null)
            {
                throw new ArgumentException(customerToBeModifiedCannotBeNullExceptionMessage);
            }

            using (dbContext)
            {
                var customer = GetCustomerById(id);
                customer.CompanyName = newCompanyName;
                dbContext.Entry(customer).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public static Customer GetCustomerById(string id)
        {
            var dbContext = new NorthwindEntities();
            using (dbContext)
            {
                return dbContext.Customers.SingleOrDefault(x => x.CustomerID == id);
            }
        }

        //Task 3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
        public static ICollection<Customer> GetCustomersWithOrdersIn1997ToCanada()
        {
            var dbContext = new NorthwindEntities();

            using (dbContext)
            {
                var result = dbContext.Orders
                    .Where(x => x.ShipCountry == "Canada" && x.OrderDate.Value.Year == 1997)
                    .Select(x => x.Customer)
                    .Distinct()
                    .ToList();

                return result;
            }
        }

        //Task 4. Implement previous by using native SQL query and executing it through the DbContext.
        public static ICollection<string> GetCustomersWithOrdersIn1997ToCanadaBySqlQuery()
        {
            var dbContext = new NorthwindEntities();

            using (dbContext)
            {
                var queryString = @"
SELECT DISTINCT c.CompanyName AS [CompanyName]
                        FROM Customers c 
                        JOIN Orders o ON c.[CustomerID] = o.[CustomerID] 
                        WHERE o.ShipCountry = 'Canada'
                        AND DATEPART(YEAR, o.ShippedDate) = 1997";

                var result = dbContext.Database.SqlQuery<string>(queryString);
                return result.ToList();
            }
        }

        //Task 5. Write a method that finds all the sales by specified region and period (start / end dates).
        public static ICollection<Order> GetOrdersByRegionAndPeriod(string region, DateTime fromDate, DateTime toDate)
        {
            var dbContext = new NorthwindEntities();
            using (dbContext)
            {
                var result = dbContext.Orders
                    .Where(o => o.ShipRegion == region && o.ShippedDate > fromDate && o.ShippedDate < toDate)
                    .OrderBy(o => o.OrderDate);

                return result.ToList();
            }

        }
    }
}