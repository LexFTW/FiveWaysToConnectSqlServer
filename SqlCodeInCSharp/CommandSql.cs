using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCodeInCSharp
{
    public class CommandSql
    {

        public CommandSql(string query, Connection connection)
        {
            Command = new SqlCommand(query, connection.GetConnection);
        }

        public SqlCommand Command { get; private set; }
    }
}
