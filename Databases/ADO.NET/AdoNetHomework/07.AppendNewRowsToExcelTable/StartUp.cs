using System;
using System.Data.OleDb;
using System.Linq;

namespace _07.AppendNewRowsToExcelTable
{
    public class StartUp
    {
        public static void Main()
        {
            string physicalPath = @"C:\Users\User\Documents\DataBases\ADO.NET\scores.xlsx";
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + physicalPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=0\"";          
            string sqlQuery = "INSERT INTO [Sheet1$] (Name, Score) VALUES (@name, @score)";

            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand(sqlQuery, connection);

            string name = "Pesho Ivanov";
            double score = 32;

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@score", score);

            connection.Open();

            using (connection)
            {
                command.ExecuteNonQuery();

                Console.WriteLine("New row is inserted successfully");
            }
        }
    }
}
