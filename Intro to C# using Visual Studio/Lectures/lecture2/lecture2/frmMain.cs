using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture2 {
    public partial class frmMain : Form {
        int totalClicks = 0;

        public frmMain() {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e) {
            //declare string variable
            string output;

            output = tbxFirstName.Text + " " + tbxMiddleName.Text + " " + tbxLastName.Text + " is " + tbxAge.Text + " years old.";

            if(tbxFirstName.Text != "" && tbxMiddleName.Text != "" && tbxLastName.Text != "" && tbxAge.Text != "") {
                lblOutput.Text = output;
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            tbxFirstName.Text = "";
            tbxMiddleName.Text = "";
            tbxLastName.Text = "";
            tbxAge.Text = "";

            tbxYearBorn.Text = "";
            tbxCurrentYear.Text = "";
            tbxPayRate.Text = "";
            tbxHoursWorked.Text = "";

            lblOutput.Text = "";

            totalClicks = 0;
            lblClicks.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnAge_Click(object sender, EventArgs e) {
            //create local variables
            try {
                int age;
                int born = int.Parse(tbxYearBorn.Text);
                int year = int.Parse(tbxCurrentYear.Text);

                age = year - born;

                lblOutput.Text = age.ToString();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);

                tbxYearBorn.Text = "";
                tbxCurrentYear.Text = "";
            }
        }

        private void btnWage_Click(object sender, EventArgs e) {
            label7.BackColor = Color.Coral;

            decimal wage = 100;
            MessageBox.Show("Wage before calculation: $" + wage);

            try {
                int hours = int.Parse(tbxHoursWorked.Text);
                double rate = double.Parse(tbxPayRate.Text);

                wage = hours * (decimal)rate;

                lblOutput.Text = wage.ToString("C");
            }
            catch {
                MessageBox.Show("Invalid data entered.");

                tbxPayRate.Text = "";
                tbxHoursWorked.Text = "";
            }
        }

        private void pbxPicture_Click(object sender, EventArgs e) {
            ++totalClicks;

            lblClicks.Text = totalClicks.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            lblClicks.Text = "0";
        }
    }
}
