using System;
using System.Data.SqlClient;
using System.Linq;

namespace _03.ProductsInCategories
{
    public class StartUp
    {
        public static void Main()
        {
            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS; Database = Northwind;Integrated Security = true");

            connection.Open();
            Console.WriteLine("Connection opened");

            using (connection)
            {
                var sql = "select DISTINCT c.[CategoryName], p.[ProductName] from Categories c join Products p ON p.[CategoryID] = c.[CategoryID]";

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        var categoryName = reader[0];
                        var products = reader[1];

                        Console.WriteLine($"Category name: {categoryName} \r\n Products: {products}");
                    }
                }
            }

            Console.WriteLine("Connection closed");
        }
    }
}
