using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetanaTest1B {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnName_Click(object sender, EventArgs e) {
            //Combines names from first name and last name textboxes
            MessageBox.Show(tbxFirstName.Text + " " + tbxLastName.Text);
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            try {
                float firstNumber = float.Parse(tbxFirstNumber.Text);
                float secondNumber = float.Parse(tbxSecondNumber.Text);

                //Adds, subtracts, or multiplies based on which radio button is checked
                if(radAdd.Checked) {
                    lblResult.Text = (firstNumber + secondNumber).ToString();
                }
                else if(radSubtract.Checked) {
                    lblResult.Text = (firstNumber - secondNumber).ToString();
                }
                else if(radMultiply.Checked) {
                    lblResult.Text = (firstNumber * secondNumber).ToString();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
