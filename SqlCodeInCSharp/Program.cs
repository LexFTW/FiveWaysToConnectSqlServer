using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using SqlCodeInCSharp.Properties;

namespace SqlCodeInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(Resources.sqlConnection);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Resources.sqlQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["StudentId"] + ", "
                        + reader["Name"] + ", " + reader["Surname"] + ", "
                        + reader["Birthday"]);
                }
            }
            finally
            {
                connection.Close();
            }
            Console.ReadLine();

        }
    }
}
