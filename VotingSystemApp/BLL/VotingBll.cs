using System.Collections.Generic;

namespace VotingSystemApp
{
    internal class VotingBll
    {
        public static List<Candidate> GetCandidateList()
        {
            return VotingGateway.GetCandidateList();
        }

        public static int GetVoterID(string email)
        {
            return VotingGateway.GetVoterID(email);
        }

        public static string VoteCast(int voterId, int candidateId)
        {
            if (VotingGateway.NumberOfVoteOfAVoter(voterId) < Candidate.numberOfWinner)
            {
                VotingGateway.VoteCast(voterId, candidateId);
                return "vote has been casted";
            }
            return "You have already casted your"+Candidate.numberOfWinner+" votes";
        }
    }
}