using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace VotingSystemApp
{
    internal class VoteGateway
    {

        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;

        private static void CallForConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["VotingSystem"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }
        public static List<Candidate> GetCandidateList()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM t_candidate");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Candidate> candidateList = new List<Candidate>();

            if (aReader.HasRows)
                while (aReader.Read())
                {
                    Candidate aCandidate=new Candidate();
                    aCandidate.CandidateID = (int)aReader[0];
                    aCandidate.Name = aReader[1].ToString();
                    aCandidate.Symbol = aReader[2].ToString();
                    candidateList.Add(aCandidate);
                }
            connection.Close();
            return candidateList;   
        }
    }
}