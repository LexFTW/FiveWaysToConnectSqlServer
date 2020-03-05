using System;
using System.Data.SqlClient;
using SqlCodeInCSharp.Properties;

namespace SqlCodeInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programObj = new Program();
            programObj.InsertExample();
            programObj.SelectExample();
            programObj.UpdateExample();
            programObj.DeleteExample();
        }

        private void DeleteExample()
        {
            throw new NotImplementedException();
        }

        private void UpdateExample()
        {
            throw new NotImplementedException();
        }

        private void InsertExample()
        {
            Connection connection = new Connection();
            connection.OpenConnection();

            CommandSql command = new CommandSql(Resources.sqlQueryInsert, connection);
            command.Command.Parameters.AddWithValue("@studentName", "Alexis");
            command.Command.Parameters.AddWithValue("@studentSurname", "Mengual Vázquez");
            command.Command.ExecuteNonQuery();

            command.Command.Parameters.AddWithValue("@studentName", "Sonia");
            command.Command.Parameters.AddWithValue("@studentSurname", "Arenas");
            command.Command.ExecuteNonQuery();

            connection.CloseConnection();
        }

        private void SelectExample()
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
