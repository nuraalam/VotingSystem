namespace VotingSystemApp
{
    partial class MainUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CandidateEntryButton = new System.Windows.Forms.Button();
            this.selectNumberOfWinnerButton = new System.Windows.Forms.Button();
            this.voteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CandidateEntryButton
            // 
            this.CandidateEntryButton.Location = new System.Drawing.Point(84, 47);
            this.CandidateEntryButton.Name = "CandidateEntryButton";
            this.CandidateEntryButton.Size = new System.Drawing.Size(145, 74);
            this.CandidateEntryButton.TabIndex = 0;
            this.CandidateEntryButton.Text = "Candidate Entry";
            this.CandidateEntryButton.UseVisualStyleBackColor = true;
            this.CandidateEntryButton.Click += new System.EventHandler(this.CandidateEntryButton_Click);
            // 
            // selectNumberOfWinnerButton
            // 
            this.selectNumberOfWinnerButton.Location = new System.Drawing.Point(84, 144);
            this.selectNumberOfWinnerButton.Name = "selectNumberOfWinnerButton";
            this.selectNumberOfWinnerButton.Size = new System.Drawing.Size(145, 54);
            this.selectNumberOfWinnerButton.TabIndex = 1;
            this.selectNumberOfWinnerButton.Text = "Select Number of Winner";
            this.selectNumberOfWinnerButton.UseVisualStyleBackColor = true;
            this.selectNumberOfWinnerButton.Click += new System.EventHandler(this.selectNumberOfWinnerButton_Click);
            // 
            // voteButton
            // 
            this.voteButton.Location = new System.Drawing.Point(84, 219);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(145, 76);
            this.voteButton.TabIndex = 2;
            this.voteButton.Text = "Vote";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 338);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.selectNumberOfWinnerButton);
            this.Controls.Add(this.CandidateEntryButton);
            this.Name = "MainUi";
            this.Text = "MainUi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CandidateEntryButton;
        private System.Windows.Forms.Button selectNumberOfWinnerButton;
        private System.Windows.Forms.Button voteButton;
    }
}

