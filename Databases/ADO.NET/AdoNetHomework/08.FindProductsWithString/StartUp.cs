using System;
using System.Data.SqlClient;
using System.Linq;

namespace _08.FindProductsWithString
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Please enter text to search product:");
            string input = Console.ReadLine();;
            Console.WriteLine("Products containing text: {0}", input);

            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS; Database = Northwind;Integrated Security = true");

            connection.Open();
            Console.WriteLine("Connection opened");

            using (connection)
            {
                SearchProductsContainingString(connection, input);
            }

            Console.WriteLine("Connection closed");
            
        }

        private static void SearchProductsContainingString(SqlConnection connection, string input)
        {
            input = EscapeInputString(input);

            string sqlQuery = "SELECT [ProductName] FROM Products WHERE CHARINDEX(@input, ProductName) > 0";

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@input", input);
            using (connection)
            {
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var productName = (string) reader["ProductName"];
                        Console.WriteLine($"{productName}");
                    }
                }
            }
        }

        private static string EscapeInputString(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\'')
                {
                    input = input.Substring(0, i) + "'" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '_')
                {
                    input = input.Substring(0, i) + "/" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '%')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '&')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }
            }
            return input;
        }
    }
}
