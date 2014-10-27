using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApp.DLL.Gateway
{
    class Gateway
    {
        public SqlConnection connection;
        public SqlCommand command;
        public string query;

        public void CallForConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["VotingSystem"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }
    }
}
