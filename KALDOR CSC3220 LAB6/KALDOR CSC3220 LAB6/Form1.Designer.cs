namespace KALDOR_CSC3220_LAB6
{
    partial class radioPollForm
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
            this.startVotingButton = new System.Windows.Forms.Button();
            this.endVotingButton = new System.Windows.Forms.Button();
            this.showResultsButton = new System.Windows.Forms.Button();
            this.finalistsListBox = new System.Windows.Forms.ListBox();
            this.typeOfSandwichTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.finalistInputOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.changePollButton = new System.Windows.Forms.Button();
            this.createPollButton = new System.Windows.Forms.Button();
            this.appendPollButton = new System.Windows.Forms.Button();
            this.pollSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.voteButton = new System.Windows.Forms.Button();
            this.pollOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.resultsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pollTitleLabel = new System.Windows.Forms.Label();
            this.pollResultsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startVotingButton
            // 
            this.startVotingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.startVotingButton.Location = new System.Drawing.Point(23, 5);
            this.startVotingButton.Name = "startVotingButton";
            this.startVotingButton.Size = new System.Drawing.Size(113, 29);
            this.startVotingButton.TabIndex = 0;
            this.startVotingButton.Text = "&Start Voting";
            this.startVotingButton.UseVisualStyleBackColor = true;
            this.startVotingButton.Click += new System.EventHandler(this.startVotingButton_Click);
            // 
            // endVotingButton
            // 
            this.endVotingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.endVotingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.endVotingButton.Location = new System.Drawing.Point(160, 5);
            this.endVotingButton.Name = "endVotingButton";
            this.endVotingButton.Size = new System.Drawing.Size(113, 29);
            this.endVotingButton.TabIndex = 1;
            this.endVotingButton.Text = "&End Voting";
            this.endVotingButton.UseVisualStyleBackColor = true;
            this.endVotingButton.Click += new System.EventHandler(this.endVotingButton_Click);
            // 
            // showResultsButton
            // 
            this.showResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.showResultsButton.Location = new System.Drawing.Point(297, 5);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(113, 29);
            this.showResultsButton.TabIndex = 2;
            this.showResultsButton.Text = "Show &Results";
            this.showResultsButton.UseVisualStyleBackColor = true;
            this.showResultsButton.Click += new System.EventHandler(this.showResultsButton_Click);
            // 
            // finalistsListBox
            // 
            this.finalistsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.finalistsListBox.FormattingEnabled = true;
            this.finalistsListBox.ItemHeight = 16;
            this.finalistsListBox.Location = new System.Drawing.Point(15, 114);
            this.finalistsListBox.Name = "finalistsListBox";
            this.finalistsListBox.Size = new System.Drawing.Size(232, 228);
            this.finalistsListBox.Sorted = true;
            this.finalistsListBox.TabIndex = 3;
            // 
            // typeOfSandwichTextBox
            // 
            this.typeOfSandwichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.typeOfSandwichTextBox.Location = new System.Drawing.Point(15, 85);
            this.typeOfSandwichTextBox.Name = "typeOfSandwichTextBox";
            this.typeOfSandwichTextBox.Size = new System.Drawing.Size(232, 23);
            this.typeOfSandwichTextBox.TabIndex = 2;
            this.typeOfSandwichTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.typeOfSandwichTextBox_Validating);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.startVotingButton);
            this.panel1.Controls.Add(this.endVotingButton);
            this.panel1.Controls.Add(this.showResultsButton);
            this.panel1.Location = new System.Drawing.Point(45, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 39);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.exitButton.Location = new System.Drawing.Point(434, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 29);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 16;
            this.resultsListBox.Location = new System.Drawing.Point(353, 85);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(315, 308);
            this.resultsListBox.TabIndex = 9;
            // 
            // finalistInputOpenFileDialog
            // 
            this.finalistInputOpenFileDialog.DefaultExt = "txt";
            this.finalistInputOpenFileDialog.FileName = "finalistInput";
            // 
            // changePollButton
            // 
            this.changePollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.changePollButton.Location = new System.Drawing.Point(15, 348);
            this.changePollButton.Name = "changePollButton";
            this.changePollButton.Size = new System.Drawing.Size(105, 29);
            this.changePollButton.TabIndex = 4;
            this.changePollButton.Text = "&Change Poll";
            this.changePollButton.UseVisualStyleBackColor = true;
            this.changePollButton.Click += new System.EventHandler(this.changePollButton_Click);
            // 
            // createPollButton
            // 
            this.createPollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.createPollButton.Location = new System.Drawing.Point(15, 383);
            this.createPollButton.Name = "createPollButton";
            this.createPollButton.Size = new System.Drawing.Size(105, 29);
            this.createPollButton.TabIndex = 5;
            this.createPollButton.Text = "Cre&ate Poll";
            this.createPollButton.UseVisualStyleBackColor = true;
            this.createPollButton.Click += new System.EventHandler(this.createPollButton_Click);
            // 
            // appendPollButton
            // 
            this.appendPollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.appendPollButton.Location = new System.Drawing.Point(15, 418);
            this.appendPollButton.Name = "appendPollButton";
            this.appendPollButton.Size = new System.Drawing.Size(105, 29);
            this.appendPollButton.TabIndex = 6;
            this.appendPollButton.Text = "&Append Poll";
            this.appendPollButton.UseVisualStyleBackColor = true;
            this.appendPollButton.Click += new System.EventHandler(this.appendPollButton_Click);
            // 
            // voteButton
            // 
            this.voteButton.Enabled = false;
            this.voteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.voteButton.Location = new System.Drawing.Point(142, 348);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(105, 29);
            this.voteButton.TabIndex = 7;
            this.voteButton.Text = "&Vote";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // pollOpenFileDialog
            // 
            this.pollOpenFileDialog.FileName = "pollOpenFileDialog";
            // 
            // pollTitleLabel
            // 
            this.pollTitleLabel.AutoSize = true;
            this.pollTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pollTitleLabel.Location = new System.Drawing.Point(12, 65);
            this.pollTitleLabel.Name = "pollTitleLabel";
            this.pollTitleLabel.Size = new System.Drawing.Size(108, 17);
            this.pollTitleLabel.TabIndex = 1;
            this.pollTitleLabel.Text = "Sandwich Type:";
            // 
            // pollResultsLabel
            // 
            this.pollResultsLabel.AutoSize = true;
            this.pollResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pollResultsLabel.Location = new System.Drawing.Point(350, 65);
            this.pollResultsLabel.Name = "pollResultsLabel";
            this.pollResultsLabel.Size = new System.Drawing.Size(86, 17);
            this.pollResultsLabel.TabIndex = 8;
            this.pollResultsLabel.Text = "Poll Results:";
            // 
            // radioPollForm
            // 
            this.AcceptButton = this.startVotingButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.endVotingButton;
            this.ClientSize = new System.Drawing.Size(680, 449);
            this.Controls.Add(this.pollResultsLabel);
            this.Controls.Add(this.pollTitleLabel);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.appendPollButton);
            this.Controls.Add(this.createPollButton);
            this.Controls.Add(this.changePollButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.typeOfSandwichTextBox);
            this.Controls.Add(this.finalistsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "radioPollForm";
            this.Text = "Create Poll";
            this.Load += new System.EventHandler(this.radioPollForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startVotingButton;
        private System.Windows.Forms.Button endVotingButton;
        private System.Windows.Forms.Button showResultsButton;
        private System.Windows.Forms.ListBox finalistsListBox;
        private System.Windows.Forms.TextBox typeOfSandwichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.OpenFileDialog finalistInputOpenFileDialog;
        private System.Windows.Forms.Button changePollButton;
        private System.Windows.Forms.Button createPollButton;
        private System.Windows.Forms.Button appendPollButton;
        private System.Windows.Forms.SaveFileDialog pollSaveFileDialog;
        private System.Windows.Forms.Button voteButton;
        private System.Windows.Forms.OpenFileDialog pollOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog resultsOpenFileDialog;
        private System.Windows.Forms.Label pollTitleLabel;
        private System.Windows.Forms.Label pollResultsLabel;
    }
}

