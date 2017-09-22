using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALDOR_CSC3220_LAB8
{
  
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        const string ALLEN_HALL = "Allen Hall";
        const string PIKE_HALL = "Pike Hall";
        const string FARTHING_HALL = "Farthing Hall";
        const string UNIVERSITY_SUITES = "University Suites";

        const int ALLEN_COST = 1500;
        const int PIKE_COST = 1600;
        const int FARTHING_COST = 1800;
        const int UNIVERSITY_SUITES_COST = 2500;

        const string SEVEN_MEALS = "7 meals per week";
        const string FOURTEEN_MEALS = "14 meals per week";
        const string UNLIMITED_MEALS = "Unlimited meals per week";

        const int SEVEN_MEALS_COST = 600;
        const int FOURTEEN_MEALS_COST = 1200;
        const int UNLIMITED_MEALS_COST = 1700;

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";

            lastNameTextBox.Text = "";
            emailAddressTextBox.Text = "";

            allenHallRadioButton.Checked = true;
            allenHallRadioButton.Checked = false;

            sevenMealsRadioButton.Checked = true;
            sevenMealsRadioButton.Checked = false;
        }

        public void showResultsButton_Click(object sender, EventArgs e)
        {
            Student currentStudent = new Student();
            currentStudent.FirstName = firstNameTextBox.Text;
            currentStudent.LastName = lastNameTextBox.Text;
            currentStudent.Email = emailAddressTextBox.Text;

            Dorm currentDorm = new Dorm();
            if (pikeHallRadioButton.Checked == true)
            {
                currentDorm.DormName = PIKE_HALL;
                currentDorm.Cost = PIKE_COST;
            }
            else if (allenHallRadioButton.Checked == true)
            {
                currentDorm.DormName = ALLEN_HALL;
                currentDorm.Cost = ALLEN_COST;
            }
            else if (farthingHallRadioButton.Checked == true)
            {
                currentDorm.DormName = FARTHING_HALL;
                currentDorm.Cost = FARTHING_COST;
            }
            else if (universitySuitesRadioButton.Checked == true)
            { 
                currentDorm.DormName = UNIVERSITY_SUITES;
                currentDorm.Cost = UNIVERSITY_SUITES_COST;
            }
            currentStudent.Dorm = currentDorm;

            MealPlan currentMealPlan = new MealPlan();
            if (sevenMealsRadioButton.Checked == true)
            {
                currentMealPlan.PlanName = SEVEN_MEALS;
                currentMealPlan.Cost = SEVEN_MEALS_COST;
            }
            else if (fourteenMealsRadioButton.Checked == true)
            {
                currentMealPlan.PlanName = FOURTEEN_MEALS;
                currentMealPlan.Cost = FOURTEEN_MEALS_COST;
            }
            else if (unlimitedMealsRadioButton.Checked == true)
            {
                currentMealPlan.PlanName = UNLIMITED_MEALS;
                currentMealPlan.Cost = UNLIMITED_MEALS_COST;
            }
            currentStudent.MealPlan = currentMealPlan;

            resultsForm Results = new resultsForm();
            Results.student = currentStudent;
            
            Results.Show();

        }


    }
}
