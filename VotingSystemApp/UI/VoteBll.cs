using System.Collections.Generic;

namespace VotingSystemApp
{
    internal class VoteBll
    {
        public static List<Candidate> GetCandidateList()
        {
            return VoteGateway.GetCandidateList();
        }
    }
}