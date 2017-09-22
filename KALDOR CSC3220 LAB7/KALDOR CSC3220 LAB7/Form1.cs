using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALDOR_CSC3220_LAB7
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            dateStatusLabel.Text = DateTime.Now.ToString("d");
            fontNameStatusLabel.Text = mainTextBox.Font.Name.ToString() + " " + mainTextBox.Size.ToString();
            italicStatusLabel.Text = "";
            boldStatusLabel.Text = "";
            underlineStatusLabel.Text = "";
        }

        void clearText()
        {
            mainTextBox.Text = "";
      
        }

        void redTextBox()
        {
            mainTextBox.ForeColor = Color.White;
            mainTextBox.BackColor = Color.Maroon;
        }

        void greenTextBox()
        {
            mainTextBox.ForeColor = Color.White;
            mainTextBox.BackColor = Color.DarkGreen;
        }

        void blueTextBox()
        {
            mainTextBox.ForeColor = Color.White;
            mainTextBox.BackColor = Color.DarkBlue;
        }


        //
        //
        //
        ///////EVENT HANDLERS///////
        //
        //
        //

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainFontDialog.MinSize = 10;
            mainFontDialog.MaxSize = 20;
            mainFontDialog.ShowEffects = true;
            mainFontDialog.ShowColor = true;

            mainFontDialog.ShowApply = true;

            mainFontDialog.ShowDialog();
            mainTextBox.Font = mainFontDialog.Font;
            mainTextBox.ForeColor = mainFontDialog.Color;
            fontNameStatusLabel.Text = mainTextBox.Font.Name.ToString() + " " + mainTextBox.Size.ToString();

            if (mainTextBox.Font.Bold == true)
                boldStatusLabel.Text = "Bold";
            else
                boldStatusLabel.Text = "";

            if (mainTextBox.Font.Italic == true)
                italicStatusLabel.Text = "Italic";
            else
                italicStatusLabel.Text = "";

            if (mainTextBox.Font.Underline == true)
                underlineStatusLabel.Text = "Underline";
            else
                underlineStatusLabel.Text = "";

        }

        private void redColorToolStripButton_Click(object sender, EventArgs e)
        {
            redTextBox();
        }

        private void greenColorToolStripButton_Click(object sender, EventArgs e)
        {
            greenTextBox();
        }

        private void blueColorToolStripButton_Click(object sender, EventArgs e)
        {
            blueTextBox();
        }

        private void clearTextToolStripButton_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redTextBox();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            greenTextBox();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blueTextBox();
        }

        private void fontDialogToolStripButton_Click(object sender, EventArgs e)
        {
            mainFontDialog.MinSize = 10;
            mainFontDialog.MaxSize = 20;
            mainFontDialog.ShowEffects = true;
            mainFontDialog.ShowColor = true;
            mainFontDialog.ShowApply = true;

            mainFontDialog.ShowDialog();
            mainTextBox.Font = mainFontDialog.Font;
            mainTextBox.ForeColor = mainFontDialog.Color;
            
            fontNameStatusLabel.Text = mainTextBox.Font.Name.ToString() + " " + mainTextBox.Size.ToString();

            if (mainTextBox.Font.Bold == true)
                boldStatusLabel.Text = "Bold";
            else
                boldStatusLabel.Text = "";

            if (mainTextBox.Font.Italic == true)
                italicStatusLabel.Text = "Italic";
            else
                italicStatusLabel.Text = "";

            if (mainTextBox.Font.Underline == true)
                underlineStatusLabel.Text = "Underline";
            else
                underlineStatusLabel.Text = "";
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainColorDialog.ShowDialog();
            mainTextBox.BackColor = mainColorDialog.Color;
        }

        private void fontColorDialogToolStripButton_Click(object sender, EventArgs e)
        {
            mainColorDialog.ShowDialog();
            mainTextBox.BackColor = mainColorDialog.Color;
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            using (mainAboutBox dialogAbout = new mainAboutBox())
            {
                dialogAbout.ShowDialog(this);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (mainAboutBox dialogAbout = new mainAboutBox())
            {
                dialogAbout.ShowDialog(this);
            }
        }




    }
}
