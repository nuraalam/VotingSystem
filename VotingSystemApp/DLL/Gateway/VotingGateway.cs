using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using VotingSystemApp.DLL.Gateway;

namespace VotingSystemApp
{
    class VotingGateway:Gateway
    {

       
        public  List<Candidate> GetCandidateList()
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

        public  int GetVoterID(string email)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM t_voter");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            int voterID = 0;

            if (aReader.HasRows)
                while (aReader.Read())
                {
                    if (email == aReader[1].ToString())
                        voterID = (int)aReader[0];

                }
            connection.Close();
            return voterID;
        }

        public  void VoteCast(int voterId, int candidateId)
        {
            CallForConnection();
            connection.Open();
            query = "INSERT INTO t_voting (VoterID,CandidateID) Values(@0,@1)";
            command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@0", voterId);
            command.Parameters.AddWithValue("@1", candidateId);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public  int NumberOfVoteOfAVoter(int voterId)
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
                    if (voterId == (int) aReader[1])
                        count++;

                }
            connection.Close();
            return count;
        }
    }
}