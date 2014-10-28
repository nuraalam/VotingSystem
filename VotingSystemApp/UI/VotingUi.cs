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
    public partial class VotingUi : Form
    {
        VotingBll aVotingBll = new VotingBll();
        private Voter aVoter;
        private Candidate selectedItem;

        public VotingUi()
        {
            InitializeComponent();
            ShowSymbolOfCandidateInComboBox();
        }

        private void ShowSymbolOfCandidateInComboBox()
        {
            
            List<Candidate> candidatesList = aVotingBll.GetCandidateList();
            foreach (var candidate in candidatesList)
            {
                selectSymbolOfCandidateComboBox.Items.Add(candidate);
            }
            selectSymbolOfCandidateComboBox.DisplayMember = "Symbol";
        }

        private void castButton_Click(object sender, EventArgs e)
        {
            if (votersEmailAddressTextBox.Text == "" || selectSymbolOfCandidateComboBox.Text == "")
            {
                MessageBox.Show("Please fill the filled accordingly");
                return;
            }
            aVoter = new Voter();
            aVoter.Email = votersEmailAddressTextBox.Text;
            aVoter.VoterID = aVotingBll.GetVoterID(aVoter.Email);
            selectedItem = new Candidate();
            selectedItem = (Candidate) selectSymbolOfCandidateComboBox.SelectedItem;
            string msg = aVotingBll.VoteCast(aVoter.VoterID, selectedItem.CandidateID);
            MessageBox.Show(msg);

        }
    }
}
