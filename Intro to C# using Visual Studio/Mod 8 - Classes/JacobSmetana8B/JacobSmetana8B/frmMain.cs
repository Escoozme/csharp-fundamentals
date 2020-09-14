using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana8B {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        //Variables for dormitory cost and meal plan cost
        decimal dormitory = 0m, mealPlan = 0m;

        //Determines prices based on selected items in listboxes
        private void lbxDormitory_SelectedIndexChanged(object sender, EventArgs e) {
            if((string)lbxDormitory.SelectedItem == "Allan Hall")
                dormitory = 1500;
            else if((string)lbxDormitory.SelectedItem == "Pike Hall")
                dormitory = 1600;
            else if((string)lbxDormitory.SelectedItem == "Farthing Hall")
                dormitory = 1800;
            else if((string)lbxDormitory.SelectedItem == "University Suites")
                dormitory = 2500;
        }

        private void lbxMealPlan_SelectedIndexChanged(object sender, EventArgs e) {
            if((string)lbxMealPlan.SelectedItem == "7 meals per week")
                mealPlan = 600;
            else if((string)lbxMealPlan.SelectedItem == "14 meals per week")
                mealPlan = 1200;
            else if((string)lbxMealPlan.SelectedItem == "Unlimited meals")
                mealPlan = 1700;
        }

        //Display Button----------------------------------------------------------
        private void btnDisplay_Click(object sender, EventArgs e) {
            decimal total = dormitory + mealPlan;

            lblOutput.Text = "Dormitory: " + dormitory.ToString("C2") + " per semester\n";
            lblOutput.Text += "Meal Plans: " + mealPlan.ToString("C2") + " per semester\n";
            lblOutput.Text += "Total: " + total.ToString("C2");
        }

        //Clear and Exit Buttons--------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e) {
            lblOutput.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
