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
    public partial class VoteUi : Form
    {
        public VoteUi()
        {
            InitializeComponent();
            ShowSymbolOfCandidateInComboBox();
        }

        private void ShowSymbolOfCandidateInComboBox()
        {
            List<Candidate> candidatesList = VoteBll.GetCandidateList();
            foreach (var candidate in candidatesList)
            {
                selectSymbolOfCandidateComboBox.Items.Add(candidate);
            }
            selectSymbolOfCandidateComboBox.DisplayMember = "Symbol";
        }

        private void castButton_Click(object sender, EventArgs e)
        {
          Voter aVoter=new Voter();
        }
    }
}
