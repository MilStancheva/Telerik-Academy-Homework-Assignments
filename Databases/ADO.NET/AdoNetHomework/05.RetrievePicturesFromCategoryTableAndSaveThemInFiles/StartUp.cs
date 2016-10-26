using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace _05.RetrievePicturesFromCategoryTableAndSaveThemInFiles
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
                var sql = "select [CategoryName], [Picture] from Categories";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        var categoryName = (string) reader["CategoryName"];
                        categoryName = categoryName.Replace('/', '_');
                        byte[] picture = (byte[]) reader["Picture"];
                        string fileName = string.Format(@"..\..\images\{0}.jpg", categoryName);
                        WriteFile(fileName, picture);
                        Console.WriteLine($"Picture for category {categoryName} saved in folder images.");
                    }
                }
            }

            Console.WriteLine("Connection closed");
        }

        private static void WriteFile(string fileName, byte[] fileContents)
        {
            int startOffset = 78;

            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, startOffset, fileContents.Length - startOffset);
            }
        }
    }
}
