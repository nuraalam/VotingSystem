using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemApp
{
    public partial class CandidateEntryUi : Form
    {
        private Candidate aCandidate;
        private CandidateEntryBLL aCandidateEntryBll;

        public CandidateEntryUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aCandidate = new Candidate(candidateNameTextBox.Text,symbolTextBox.Text);
            aCandidateEntryBll = new CandidateEntryBLL();
            string msg = aCandidateEntryBll.Save(aCandidate);
            MessageBox.Show(msg);

        }
    }
}
