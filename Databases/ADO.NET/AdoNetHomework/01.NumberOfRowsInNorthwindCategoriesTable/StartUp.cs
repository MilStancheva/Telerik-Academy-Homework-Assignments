using System;
using System.Data.SqlClient;
using System.Linq;

namespace _01.NumberOfRowsInNorthwindCategoriesTable
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
                SqlCommand command = new SqlCommand("select count (*) from Categories", connection);
                var count = (int)command.ExecuteScalar();
                Console.WriteLine("Number of categories (rows): {0}", count);
            }

            Console.WriteLine("Connection closed");
        }
    }
}
