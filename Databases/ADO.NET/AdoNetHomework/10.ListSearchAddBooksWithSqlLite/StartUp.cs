using System;
using System.Data.SQLite;
using System.Linq;

namespace _10.ListSearchAddBooksWithSqlLite
{
    public class StartUp
    {
        public static void Main()
        {
            //couldn't manage the connection string :( 
            string connectionString = "Data Source =:memory:; Version = 3; New = True";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();
            using (connection)
            {
                AddNewBook(connection, "Frankenstein; Or, The Modern Prometheus", "Shelley, Mary Wollstonecraft, 1797-1851", DateTime.Parse("1993.10.01"), 1234567890123);
                AddNewBook(connection, "Alice's Adventures in Wonderland", "Carroll, Lewis, 1832-1898", DateTime.Parse("2008.07.27"), 1234567890122);
                AddNewBook(connection, "Dracula", "Stoker, Bram, 1847-1912", DateTime.Parse("1995.10.01"), 1234567890111);
                Console.WriteLine("Inserted new products");
                Console.WriteLine(new string('-', 50));

                ListBooks(connection);
                Console.WriteLine(new string('-', 50));

                Console.Write("Please enter text to search a book:");
                string input = Console.ReadLine(); ;
                Console.WriteLine("Books containing text: {0}", input);
                SearchBooksContainingPattern(connection, input);
            }
        }

        private static void SearchBooksContainingPattern(SQLiteConnection connection, string pattern)
        {
            pattern = EscapeInputString(pattern);

            string sqlQuery = string.Format("SELECT title FROM books WHERE title LIKE '%{0}%'", pattern);

            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader  reader = command.ExecuteReader();
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

        private static void ListBooks(SQLiteConnection dbConnection)
        {
            string sqlQuery = "SELECT * FROM Books";

            SQLiteCommand command = new SQLiteCommand(sqlQuery, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    var title = (string) reader["title"];
                    var author = (string) reader["author"];
                    DateTime publishDate = (DateTime) reader["publish_date"];
                    var isbn = (long) reader["isbn"];
                    Console.WriteLine("{0} -> {1}, {2}, {3}", title, author, publishDate.ToString(), isbn);
                }
            }
        }

        private static void AddNewBook(SQLiteConnection connection, string title, string author, DateTime publishDate, long isbn)
        {
            string sqlStringCommand = "INSERT INTO Books(title, author, publish_date, isbn) VALUES (@title, @author, @publish_date, @isbn)";

            SQLiteCommand command = new SQLiteCommand(sqlStringCommand, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@publish_date", publishDate);
            command.Parameters.AddWithValue("@isbn", isbn);

            command.ExecuteNonQuery();
        }
    }
}
