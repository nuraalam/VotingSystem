namespace VotingSystemApp
{
    class CandidateEntryBLL
    {
        public string Save(Candidate aCandidate)
        {
           CandidateEntryGateway aCandidateEntryGateway=new CandidateEntryGateway();
            aCandidateEntryGateway.Save(aCandidate);
            
            return "Saved";
        }
    }
}