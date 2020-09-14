using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana2A {
    public partial class frmMain : Form {

        public frmMain() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            //Clear textbox and label
            tbxSpeed.Text = "";
            lblOutput.Text = "";
        }

        private void btnFive_Click(object sender, EventArgs e) {
            //Distance traveled in 5 hours
            try {
                lblOutput.Text = (5 * int.Parse(tbxSpeed.Text)).ToString() + " miles";
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEight_Click(object sender, EventArgs e) {
            //Distance traveled in 8 hours
            try {
                lblOutput.Text = (8 * int.Parse(tbxSpeed.Text)).ToString() + " miles";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTwelve_Click(object sender, EventArgs e) {
            //Distance traveled in 12 hours
            try {
                lblOutput.Text = (12 * int.Parse(tbxSpeed.Text)).ToString() + " miles";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
