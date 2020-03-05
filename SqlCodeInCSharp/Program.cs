using System;
using System.Data.SqlClient;
using SqlCodeInCSharp.Properties;

namespace SqlCodeInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection connection = new Connection();
            connection.OpenConnection();
            CommandSql command = new CommandSql(Resources.sqlQuery, connection);
            ReaderSql reader = new ReaderSql(command);
            string[] columns = { "StudentId", "Name", "Surname", "Birthday" };
            string result = reader.ReadQuery(columns);
            connection.CloseConnection();
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
