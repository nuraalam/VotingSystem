using System;
using System.Collections.Generic;

namespace VotingSystemApp
{
    class VotingBll
    {
        VotingGateway aVotingGateway=new VotingGateway();
        public  List<Candidate> GetCandidateList()
        {
            return aVotingGateway.GetCandidateList();
        }

        public  int GetVoterID(string email)
        {
            return aVotingGateway.GetVoterID(email);
        }

        public  string VoteCast(int voterId, int candidateId)
        {
            if (Candidate.numberOfWinner == 0)
                return "Number of winner has not been selected for this election\nYour vote will not be casted at this moment";
            if (aVotingGateway.NumberOfVoteOfAVoter(voterId) < Candidate.numberOfWinner)
            {
                try
                {
                    aVotingGateway.VoteCast(voterId, candidateId);
                }
                catch (Exception)
                {

                    return "Your email is not registared for this vote";
                }
               
                return "Vote has been casted";
            }
            return "You have already casted your "+Candidate.numberOfWinner+" votes";
        }
    }
}