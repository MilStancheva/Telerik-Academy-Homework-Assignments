using System;
using System.Data.SqlClient;
using System.Linq;

namespace _04.AddNewProductInProductsTable
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
                var sql = "insert into Products(ProductName) values (@newProduct)";
                var productValue = "Stratichella";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@newProduct", productValue);
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"rows affected: {rowsAffected}");

                command.CommandText = "select @@Identity";
                var id = command.ExecuteScalar();
                Console.WriteLine($"ID: {id}");
            }

            Console.WriteLine("Connection closed");
        }
    }
}
