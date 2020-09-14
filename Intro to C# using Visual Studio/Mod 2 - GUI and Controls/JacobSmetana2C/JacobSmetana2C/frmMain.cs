using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana2C {
    public partial class frmMain : Form {
        int totalCalories = 0;

        public frmMain() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            //reset total calories counter
            lblTotalCalories.Text = "0";
            totalCalories = 0;

            lblTotalCalories.BackColor = DefaultBackColor;
        }

        private void pbxOrange_Click(object sender, EventArgs e) {
            //adds orange calories to total calories and changes output label background color to orange
            lblTotalCalories.Text = (totalCalories += 90).ToString();

            lblTotalCalories.BackColor = Color.Orange;
        }

        private void pbxPear_Click(object sender, EventArgs e) {
            //adds pear calories to total calories and changes output label background color to green
            lblTotalCalories.Text = (totalCalories += 120).ToString();

            lblTotalCalories.BackColor = Color.PaleGreen;
        }

        private void pbxBanana_Click(object sender, EventArgs e) {
            //adds banana calories to total calories and changes output label background color to yellow
            lblTotalCalories.Text = (totalCalories += 115).ToString();

            lblTotalCalories.BackColor = Color.Yellow;
        }

        private void pbxApple_Click(object sender, EventArgs e) {
            //adds apple calories to total calories and changes output label background color to red
            lblTotalCalories.Text = (totalCalories += 80).ToString();

            lblTotalCalories.BackColor = Color.Red;
        }
    }
}
