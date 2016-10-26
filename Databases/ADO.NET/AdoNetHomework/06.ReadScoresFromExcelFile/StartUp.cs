using System;
using System.Data.OleDb;
using System.Linq;

namespace _06.ReadScoresFromExcelFile
{
    public class StartUp
    {
        public static void Main()
        {
            string physicalPath = @"C:\Users\User\Documents\DataBases\ADO.NET\scores.xlsx";
           
            string strNewPath = physicalPath;
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strNewPath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
            string sqlQuery = "SELECT * FROM [Sheet1$]";
            OleDbConnection connection = new OleDbConnection(connString);

            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            connection.Open();

            using (connection)
            {
                OleDbDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string) reader["Name"];
                        double score = (double) reader["Score"];
                        Console.WriteLine($"{name} -> {score}");
                    }
                }
            }           
        }
    }
}
