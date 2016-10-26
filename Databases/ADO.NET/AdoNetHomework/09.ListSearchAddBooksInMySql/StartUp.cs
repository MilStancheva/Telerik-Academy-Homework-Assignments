using System;
using System.Linq;
using MySql.Data.MySqlClient;

namespace _09.ListSearchAddBooksInMySql
{
    public class StartUp
    {
        public static void Main()
        {
            string connectionString = "Server=localhost; Port=3306;Database=library; Uid = root; Pwd = yourpassword; pooling = true";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            using (connection)
            {
                int firstBookId = AddNewBook(connection, "Frankenstein; Or, The Modern Prometheus", "Shelley, Mary Wollstonecraft, 1797-1851", DateTime.Parse("1993.10.01"), 1234567890123);
                int secondBookId = AddNewBook(connection, "Alice's Adventures in Wonderland", "Carroll, Lewis, 1832-1898", DateTime.Parse("2008.07.27"), 1234567890122);
                int thirdBookId = AddNewBook(connection, "	Dracula", "Stoker, Bram, 1847-1912", DateTime.Parse("1995.10.01"), 1234567890111);
                Console.WriteLine("Inserted new product with Id: {0}", firstBookId);
                Console.WriteLine("Inserted new product with Id: {0}", secondBookId);
                Console.WriteLine("Inserted new product with Id: {0}", thirdBookId);

                Console.WriteLine(new string('-', 50));

                ListBooks(connection);
                Console.WriteLine(new string('-', 50));

                Console.Write("Please enter text to search a book:");
                string input = Console.ReadLine(); ;
                Console.WriteLine("Books containing text: {0}", input);
                SearchBooksContainingPattern(connection, input);
            }
        }

        private static void SearchBooksContainingPattern(MySqlConnection connection, string pattern)
        {
            pattern = EscapeInputString(pattern);

            string sqlQuery = string.Format("SELECT title FROM books WHERE title LIKE '%{0}%'", pattern);

            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    var title = (string) reader["title"];
                    Console.WriteLine($"{title}");
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

        private static void ListBooks(MySqlConnection dbConnection)
        {
            string sqlQuery = "SELECT * FROM Books";

            MySqlCommand command = new MySqlCommand(sqlQuery, dbConnection);
            MySqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    var title = (string) reader["title"];
                    var author = (string) reader["author"];
                    DateTime publishDate = (DateTime) reader["publish_date"];
                    var isbn = (long)reader["isbn"];
                    Console.WriteLine("{0} -> {1}, {2}, {3}", title, author, publishDate.ToString(), isbn);
                }
            }
        }

        private static int AddNewBook(MySqlConnection connection, string title, string author, DateTime publishDate, long isbn)
        {
            string sqlStringCommand = "INSERT INTO Books(title, author, publish_date, isbn) VALUES (@title, @author, @publish_date, @isbn)";

            MySqlCommand command = new MySqlCommand(sqlStringCommand, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@publish_date", publishDate);
            command.Parameters.AddWithValue("@isbn", isbn);

            command.ExecuteNonQuery();

            return (int) command.LastInsertedId;
        }
    }
}