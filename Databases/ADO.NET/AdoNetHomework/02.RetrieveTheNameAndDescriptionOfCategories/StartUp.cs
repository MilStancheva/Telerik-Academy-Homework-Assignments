using System;
using System.Data.SqlClient;
using System.Linq;

namespace _02.RetrieveTheNameAndDescriptionOfCategories
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
                SqlCommand command = new SqlCommand("select [CategoryName], [Description] from Categories", connection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        var categoryName = reader[0];
                        var description = reader[1];

                        Console.WriteLine($"Category name: {categoryName} \r\n Description: {description}");
                    }
                }
            }

            Console.WriteLine("Connection closed");
        }
    }
}
