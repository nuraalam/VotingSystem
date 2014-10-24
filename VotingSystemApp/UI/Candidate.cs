namespace VotingSystemApp
{
    internal class Candidate
    {
        public int  CandidateID { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public static int numberOfWinner ;
        static Candidate()
        {
            numberOfWinner = 3;
        }

        public Candidate(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}