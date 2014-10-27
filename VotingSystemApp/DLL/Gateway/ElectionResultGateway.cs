using System;
using System.Configuration;
using System.Data.SqlClient;
using VotingSystemApp.DLL.Gateway;

namespace VotingSystemApp
{
    internal class ElectionResultGateway:Gateway
    {
       
        public  int GetCandidateVote(int candidateId)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM t_voting");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            int count = 0;

            if (aReader.HasRows)
                while (aReader.Read())
                {
                    if (candidateId == (int)aReader[2])
                        count++;

                }
            connection.Close();
            return count;
        }
    }
}