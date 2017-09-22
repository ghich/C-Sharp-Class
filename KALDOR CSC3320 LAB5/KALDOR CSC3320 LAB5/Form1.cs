using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALDOR_CSC3320_LAB5
{
    public partial class TeddysToyGiftSelectorForm : Form
    {
        public TeddysToyGiftSelectorForm()
        {
            InitializeComponent();
            boyRadioButton.Checked = true;
            boyRadioButton.Checked = false;
        }

        //Declaring constant variables
        const int MOBILE_PRICE = 8;
        const int BOOK_PRICE = 10;
        const int BOARD_GAME_PRICE = 12;
        const int PLAYSKOOL_TOY_PRICE = 10;

        //Declaring dynamic variables
        bool isBoy = false;
        bool isGirl = false;
        int maxPrice = 0;
        DateTime childBirthDate;
        DateTime Minimum = DateTime.Today.AddYears(-13);
        DateTime Maximum = DateTime.Today.AddMonths(2);

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stateComboBox.SelectedIndex == 5 && stateTextBox.Text == "")
            {
                if (MessageBox.Show("Please enter the state abbreviation of your choice", "Enter State",
                     MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    stateTextBox.Enabled = true;
                    stateTextBox.Visible = true;
                    stateComboBox.Visible = false;
                    stateComboBox.Enabled = false;
                    stateTextBox.Focus();
                }
            }
        }

        private void boyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (boyRadioButton.Checked == true)
                isBoy = true;
            else
                isBoy = false;
        }

        private void girlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (girlRadioButton.Checked == true)
                isGirl = true;
            else
                isGirl = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            giftToysListBox.Items.Clear();
            //The following if statements check if the all the forms boxes have been filled out or not.
            //It is not entirely thorough, but it ensures there is at least one digit per textbox, and that comboboxes are not left blank.
            if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a first name", "Error!",
                    MessageBoxButtons.OKCancel);
                firstNameTextBox.Focus();
            }
            if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a last name", "Error!",
                    MessageBoxButtons.OKCancel);
                lastNameTextBox.Focus();
            }
            if (streetAddressTextBox.Text == "")
            {
                MessageBox.Show("Please enter a street address", "Error!",
                    MessageBoxButtons.OKCancel);
                streetAddressTextBox.Focus();
            }
            if (stateComboBox.SelectedIndex == 0 && stateTextBox.Text == "")
            {
                MessageBox.Show("Please enter or select a state", "Error!",
                    MessageBoxButtons.OKCancel);
                stateTextBox.Focus();
            }
            if (zipMaskedTextBox.Text == "")
            {
                MessageBox.Show("Please enter a zip code", "Error!",
                    MessageBoxButtons.OKCancel);
               zipMaskedTextBox.Focus();
            }
            if (phoneMaskedTextBox.Text == "")
            {
                MessageBox.Show("Please enter a valid phone number (000-000-0000)", "Error!",
                    MessageBoxButtons.OKCancel);
                phoneMaskedTextBox.Focus();
            }
            if (emailTextBox.Text == "")
            {
                MessageBox.Show("Please enter an email address", "Error!",
                    MessageBoxButtons.OKCancel);
                emailTextBox.Focus();
            }
            if (childNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter the child's first name", "Error!",
                    MessageBoxButtons.OKCancel);
                childNameTextBox.Focus();
            }
            if (boyRadioButton.Checked == false && girlRadioButton.Checked == false)
            {
                MessageBox.Show("Please input the child's gender", "Error!",
                    MessageBoxButtons.OKCancel);
                childGenderGroupBox.Focus();
            }
            if (maxPriceComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a maximum price", "Error!",
                    MessageBoxButtons.OKCancel);
                maxPriceComboBox.Focus();
            }

            //Age validation input
            DateTime.TryParse(childAgeMaskedTextBox.Text, out childBirthDate);
            if (childBirthDate < Minimum)
            {
                MessageBox.Show("Child must be 13 or younger", "Error!",
                    MessageBoxButtons.OKCancel);
                return;
            }
            if (childBirthDate > Maximum)
            {
                MessageBox.Show("Child must be born within two months in the future", "Error!",
                    MessageBoxButtons.OKCancel);
                return;
            }

            // AGE VERIFICATION AND PRICE VERIFICATION FOR GIFTS

            //If child is ~12 months old
            //And max price is at least 8
            if (childBirthDate < DateTime.Today.AddMonths(2) && childBirthDate > DateTime.Today.AddMonths(-12) && maxPriceComboBox.SelectedIndex > 0)
            {
                giftToysListBox.Items.Add("Mobile $8");
                giftToysListBox.Visible = true;
                giftToysListBoxLabel.Visible = true;
            }
            
            //If child is at least one year old, but less than two years
            //And max price is at least 10
            if (childBirthDate <= DateTime.Today.AddMonths(-12) && childBirthDate >= DateTime.Today.AddMonths(-23) && maxPriceComboBox.SelectedIndex > 1)
            {
                giftToysListBox.Items.Add("Playskool Toy $10");
                giftToysListBox.Visible = true;
                giftToysListBoxLabel.Visible = true;
            }

            //If child is between 2 and 4
            //And max price is at least 15
            if (childBirthDate < DateTime.Today.AddYears(-2) && childBirthDate > DateTime.Today.AddYears(-4) && maxPriceComboBox.SelectedIndex > 3)
            {
                giftToysListBox.Items.Add("Teddy Bear $15");
                giftToysListBox.Visible = true;
                giftToysListBoxLabel.Visible = true;
            }

            //If boy is over ten
            //And max price is at least 12
            if (isBoy == true && childBirthDate < DateTime.Today.AddYears(-10) && maxPriceComboBox.SelectedIndex > 2)
            {
                giftToysListBox.Items.Add("Board Games $12");
                giftToysListBox.Visible = true;
                giftToysListBoxLabel.Visible = true;
            }

            //If boy is over ten
            //And max price is 40
            if (isBoy == true && childBirthDate < DateTime.Today.AddYears(-10) && maxPriceComboBox.SelectedIndex > 4)
            {
                giftToysListBox.Items.Add("E-Game $40");
                giftToysListBox.Visible = true;
                giftToysListBoxLabel.Visible = true;
            }

            //If boy is between 2 and 10 (inclusive)
            //And max price is at least 10
            if (isBoy == true && childBirthDate <= DateTime.Today.AddYears(-2) && childBirthDate >= DateTime.Today.AddYears(-10) && maxPriceComboBox.SelectedIndex > 1)
            {
                giftToysListBox.Items.Add("Car $10");
                giftToysListBox.Visible = true;
                giftToysListBoxLabel.Visible = true;
            }

            //If girl is between 2 and 10 (exclusive)
            //And max price is at least 15
            if (isGirl == true && childBirthDate < DateTime.Today.AddYears(-2) && childBirthDate > DateTime.Today.AddYears(-10) && maxPriceComboBox.SelectedIndex > 3)
            {
                giftToysListBox.Items.Add("Doll $15");
                giftToysListBox.Visible = true;
                giftToysListBoxLabel.Visible = true;
            }

            //If girl is over ten 
            //Price doesn't matter. Six bucks is the lowest value
            if (isGirl == true && childBirthDate <= DateTime.Today.AddYears(-10))
            {
                giftToysListBox.Items.Add("Book $6");
                giftToysListBox.Visible = true;
                giftToysListBoxLabel.Visible = true;
            }

           if (giftToysListBox.Items.Count == 0)
           {
               MessageBox.Show("There are no gifts for that age/gender within that price range", "NO GIFTS!",
                   MessageBoxButtons.OK);
           }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit application
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Reset all fields
            boyRadioButton.Checked = true;
            boyRadioButton.Checked = false;
            childNameTextBox.Text = "";
            maxPriceComboBox.SelectedIndex = -1;
            emailTextBox.Text = "";
            phoneMaskedTextBox.Text = "";
            zipMaskedTextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.SelectedIndex = -1;
            stateTextBox.Text = "";
            streetAddressTextBox.Text = "";

            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            childAgeMaskedTextBox.Text = "";

            //Reset the state inputs
            stateTextBox.Enabled = false;
            stateTextBox.Visible = false;
            stateComboBox.Visible = true;
            stateComboBox.Enabled = true;

            //Reset the max price
            maxPriceTextBox.Enabled = false;
            maxPriceTextBox.Visible = false;
            maxPriceComboBox.Visible = true;
            maxPriceComboBox.Enabled = true;


            giftToysListBox.Visible = false;
            giftToysListBoxLabel.Visible = false;
            giftToysListBox.Items.Clear();
        }

        private void maxPriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (maxPriceComboBox.SelectedIndex == 6 && maxPriceTextBox.Text == "")
            {
                if (MessageBox.Show("Please enter the max price of your choice", "Enter Max Price",
                     MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    maxPriceTextBox.Enabled = true;
                    maxPriceTextBox.Visible = true;
                    maxPriceComboBox.Visible = false;
                    maxPriceComboBox.Enabled = false;
                    maxPriceTextBox.Focus();
                }
            }
        }
        

    }
}
