using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_5 {
    public partial class frmMain : Form {

        private void ColorButtonRed() {
            btnColor.BackColor = Color.Red;
        }

        private void ColorButtonOrange(string banner) {
            btnColor.BackColor = Color.Orange;
            MessageBox.Show(banner);
        }

        public frmMain() {
            InitializeComponent();
        }

        
  


        private void btnColor_Click(object sender, EventArgs e) {
            if(tbxNumber.Text == "1")
                ColorButtonRed();
            else if(tbxNumber.Text == "2")
                ColorButtonOrange("This is Orange");
            else
                MessageBox.Show("Not valid");

            tbxNumber.Clear();
            tbxNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ShowNumbers(int value) {
            MessageBox.Show(value.ToString());
        }

        private void btnSingleValue_Click(object sender, EventArgs e) {
            ShowNumbers(100);
        }

        private void btnAddValue_Click(object sender, EventArgs e) {
            ShowNumbers(100 + 2345);
        }

        private void btnVariable_Click(object sender, EventArgs e) {
            for (int i = 0; i < 4; ++i)
                ShowNumbers(i);
        }

        private void NumberChangedVal(int value) {
            value = 1000;
            MessageBox.Show("In NumberChangedVal function, value is " + value);
        }

        private void NumberChangedRef(ref int value) {
            value = 1000;
            MessageBox.Show("In NumberChangedRef function, value is " + value);
        }

        private void btnByValue_Click(object sender, EventArgs e) {
            int number = 150;
            MessageBox.Show("Number = " + number);
            NumberChangedVal(number);
            MessageBox.Show("Number after NumberChangedVal function, value is " + number);
        }

        private void btnByRef_Click(object sender, EventArgs e) {
            int number = 15;
            MessageBox.Show("Number = " + number);
            NumberChangedRef(ref number);
            MessageBox.Show("Number after NumberChangedRef function, value is " + number);
        }

        private void NumberChangedOut(out int value) {
            value = 11;
        }

        private void btnOutputParm_Click(object sender, EventArgs e) {
            int number;
            NumberChangedOut(out number);
            MessageBox.Show("Number after NumberChangedOut function, value is " + number);
        }

        private int ChangeValueReturning(ref int value) {
            value *= 10;
            return value;
        }

        private bool IsEven(int number) {
            bool numIsEven;
            if (number % 2 == 0)
                numIsEven = true;
            else
                numIsEven = false;

            return numIsEven;
        }

        private void btnValRetMethod_Click(object sender, EventArgs e) {
            int n;
            int calcFmMet = 0;
            if(int.TryParse(tbxNumber2.Text, out n)) {
                if (IsEven(n))
                    MessageBox.Show("EVEN");
                else
                    MessageBox.Show("ODD");

                calcFmMet = ChangeValueReturning(ref n);
                MessageBox.Show("Number after calculation method is " + calcFmMet);
            }
            else {
                MessageBox.Show("Invalid.");
                tbxNumber2.Clear();
                tbxNumber2.Focus();
            }
        }
    }
}
