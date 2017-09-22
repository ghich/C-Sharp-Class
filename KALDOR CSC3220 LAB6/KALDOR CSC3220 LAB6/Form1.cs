using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KALDOR_CSC3220_LAB6
{
    public partial class radioPollForm : Form
    {
        public radioPollForm()
        {
            InitializeComponent();

        }

        private int voteCount = 0;
        private string pollFileName;
        private string resultsFileName;
        private StreamWriter outFile;
        private StreamReader inFile;
        
        //Function to read in poll data
        private void openFile()
        {
            pollResultsLabel.Text = "Poll results: ";
            finalistsListBox.Items.Clear();

            //Informing the user what to do
            MessageBox.Show("Please select a text file of the finalists for the poll", "Select Finalists",
                MessageBoxButtons.OKCancel);

            finalistInputOpenFileDialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";
            finalistInputOpenFileDialog.Title = "Select a File to Open";

            if (finalistInputOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                int count = 0;

                inFile = File.OpenText(finalistInputOpenFileDialog.FileName);

                while (!inFile.EndOfStream && count < 16)
                {
                    finalistsListBox.Items.Add(inFile.ReadLine());

                    //Counter prevents more than 15 items to be added to the list box from the text file.
                    count++;
                }
                inFile.Close();
            }

            else
                return;
        }

        //
        //
        //Event Handlers
        //
        //

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioPollForm_Load(object sender, EventArgs e)
        {           
            Application.OpenForms["radioPollForm"].BringToFront();
            this.WindowState = FormWindowState.Normal;
            openFile();

        }

        private void changePollButton_Click(object sender, EventArgs e)
        {
            openFile();
            pollResultsLabel.Visible = false;
            resultsListBox.Items.Clear();
        }

        private void startVotingButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(typeOfSandwichTextBox.Text))
            {
                MessageBox.Show("Please enter the type of sandwich poll you want to run" + Environment.NewLine + "Or press cancel and select to append a poll", "Error!",
                    MessageBoxButtons.OKCancel);
                typeOfSandwichTextBox.Focus();
            }
            voteButton.Enabled = true;
        }

        private void createPollButton_Click(object sender, EventArgs e)
        {
            pollResultsLabel.Text = "Poll results: ";
            resultsListBox.Items.Clear();

            pollSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            pollSaveFileDialog.Title = "Save to...";

            if (pollSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pollFileName = pollSaveFileDialog.FileName;

                outFile = File.CreateText(pollSaveFileDialog.FileName);
            }
            else
                return;

        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            if (outFile == null)
            {
               if (MessageBox.Show("Please select a new output file to save the votes", "Error!",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    pollSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
                    pollSaveFileDialog.Title = "Save to...";

                    if (pollSaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pollFileName = pollSaveFileDialog.FileName;

                        outFile = File.CreateText(pollSaveFileDialog.FileName);
                    }
                    else
                        return;
                }
            }
            else
            {
            //Write line per click
            outFile.WriteLine(finalistsListBox.Text);
            //Increase vote count per click
            voteCount++;
            }

        }

        private void endVotingButton_Click(object sender, EventArgs e)
        {
            voteButton.Enabled = false;
            MessageBox.Show("Total Votes: " + voteCount.ToString() + Environment.NewLine + "Saved to File: " + pollFileName, typeOfSandwichTextBox.Text,
                MessageBoxButtons.OKCancel);
            outFile.Close();
        }

        private void appendPollButton_Click(object sender, EventArgs e)
        {
            pollOpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            pollOpenFileDialog.Title = "Save to...";

            if (pollOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                pollFileName = pollOpenFileDialog.FileName;

                outFile = File.AppendText(pollOpenFileDialog.FileName);
            }
            else
            {
                return;
            }
        }


        private void typeOfSandwichTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeOfSandwichTextBox.Text))
            {
                e.Cancel = true;
                MessageBox.Show("You must enter a name for the poll", "Enter Poll Name",
                    MessageBoxButtons.OK);
            }

            else
                e.Cancel = false;
        }

        private void showResultsButton_Click(object sender, EventArgs e)
        {
            //Focus should be on what type of sandwich this poll is for
            typeOfSandwichTextBox.Focus();

            //Clear listbox
            //Open file
            //Reload listbox
            openFile();
            int votesCast = 0;
            //creating array
            int[] votes = new int[finalistsListBox.Items.Count];
            //initializing array
            for (int i = 0; i < finalistsListBox.Items.Count; i++)
            {
                votes[i] = 0;
            }

            MessageBox.Show("Please select a file with poll results in it", "Select a file",
                MessageBoxButtons.OKCancel);

            resultsOpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            resultsOpenFileDialog.Title = "Choose results file";

            if (resultsOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultsFileName = Path.GetFileName(resultsOpenFileDialog.FileName);
                inFile = File.OpenText(resultsOpenFileDialog.FileName); 
              
                while (!inFile.EndOfStream)
                {
                    string line = inFile.ReadLine();

                    for (int j = 0; j < finalistsListBox.Items.Count; j++)
                    {
                        if (finalistsListBox.Items[j].ToString() == line)
                        {
                            votes[j] += 1; 
                            votesCast++;
                        }
                       
                    }
                }
            }

            else
            {
                MessageBox.Show("No results will be shown", "Canceled",
                    MessageBoxButtons.OK);
                return;
            }
            inFile.Close();

            pollResultsLabel.Text = typeOfSandwichTextBox.Text + " poll results: ";
            resultsListBox.Items.Add("Results from: " + resultsFileName);
         
            resultsListBox.Items.Add("-------------------------");

            for (int k = 0; k < finalistsListBox.Items.Count; k++)
            {
                resultsListBox.Items.Add(finalistsListBox.Items[k].ToString() + " - " + votes[k].ToString());
            }
            resultsListBox.Items.Add("Total votes counted: " + votesCast.ToString());
        }


   
    }
}
