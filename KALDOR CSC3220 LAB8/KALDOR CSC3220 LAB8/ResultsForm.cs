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
    public partial class resultsForm : Form
    {
        public Student student = new Student();
        
        public resultsForm()
        {
            InitializeComponent();
        }

        
        

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resultsForm_Load(object sender, EventArgs e)
        {
            outputDormCostLabel.Text = "$" + student.Dorm.Cost.ToString();
            outputDormNameLabel.Text = student.Dorm.DormName;

            outputMealPlanCostLabel.Text = "$" + student.MealPlan.Cost.ToString();
            outputMealPlanLabel.Text = student.MealPlan.PlanName;

            outputTotalCostLabel.Text = "$" + student.TotalCharge.ToString();

            outputStudentNameLabel.Text = student.FullName;
            outputStudentEmailLabel.Text = student.Email;
        }

       


    }
}
