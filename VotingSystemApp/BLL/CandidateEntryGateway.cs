using System.Configuration;
using System.Data.SqlClient;

namespace VotingSystemApp
{
    internal class CandidateEntryGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;

        private static void CallForConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["VottingSystem"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }
        public void Save(Candidate aCandidate)
        {
            
        }
    }
}