using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana3A {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e) {
            try {
                //Parse number entered
                int number = int.Parse(tbxNumber.Text);

                if(number < 1 || number > 10) {
                    //For integers outside the specified range
                    MessageBox.Show("Outside of range 1 to 10.", "Error");
                }

                //Conversion of number entered to Roman numeral
                if (number == 1)
                    lblOutput.Text = "I";
                else if (number == 2)
                    lblOutput.Text = "II";
                else if (number == 3)
                    lblOutput.Text = "III";
                else if (number == 4)
                    lblOutput.Text = "IV";
                else if (number == 5)
                    lblOutput.Text = "V";
                else if (number == 6)
                    lblOutput.Text = "VI";
                else if (number == 7)
                    lblOutput.Text = "VII";
                else if (number == 8)
                    lblOutput.Text = "VIII";
                else if (number == 9)
                    lblOutput.Text = "IX";
                else
                    lblOutput.Text = "X";
            }
            catch {
                //For any non integers entered
                MessageBox.Show("Input must be an integer between 1 and 10.", "Error");
            }

            //Clear and refocus textbox
            tbxNumber.Clear();
            tbxNumber.Focus();
        }
    }
}
