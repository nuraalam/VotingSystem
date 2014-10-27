using System.Configuration;
using System.Data.SqlClient;
using VotingSystemApp.DLL.Gateway;

namespace VotingSystemApp
{
    class CandidateEntryGateway:Gateway
    {
       
        public void Save(Candidate aCandidate)
        {
            CallForConnection();
            connection.Open();
            query = "INSERT INTO t_candidate (Name,Symbol) Values(@0,@1)";
            command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@0", aCandidate.Name);
            command.Parameters.AddWithValue("@1", aCandidate.Symbol);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}