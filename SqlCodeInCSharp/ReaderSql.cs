using System;
using System.Data.SqlClient;

namespace SqlCodeInCSharp
{
    public class ReaderSql
    {
        public SqlDataReader Reader { get; private set; }


        public ReaderSql(CommandSql command)
        {
            Reader = command.Command.ExecuteReader();
        }

        public string ReadQuery(string[] columns)
        {
            string result = "";
            while (Reader.Read())
            {
                for(var index = 0; index < columns.Length; index++)
                {
                    result += Reader[columns[index]] + " | ";
                }
                result += "\n";
            }
            return result;
        }
    }
}