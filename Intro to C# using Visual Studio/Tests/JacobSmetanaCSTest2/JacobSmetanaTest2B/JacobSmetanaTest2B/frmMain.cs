using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JacobSmetanaTest2B {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        //List for holding all charge account numbers-----------------------------------
        List<string> accountNumbers = new List<string>();

        //Populate List with data from ChargeAccounts.txt on form load------------------

        private void frmMain_Load(object sender, EventArgs e) {
            StreamReader fin = File.OpenText("ChargeAccounts.txt");

            while(!fin.EndOfStream)
                accountNumbers.Add(fin.ReadLine());

            fin.Close();
        }

        //Check if number entered is a valid account number-----------------------------

        private void btnCheckValid_Click(object sender, EventArgs e) {
            int tempNum;

            if(int.TryParse(tbxAccountNumber.Text, out tempNum) && tbxAccountNumber.TextLength == 7) {
                bool valid = false;

                for(int i = 0; i < accountNumbers.Count && valid == false; ++i) {
                    if(tbxAccountNumber.Text == accountNumbers[i]) {
                        MessageBox.Show("Number entered is valid.");
                        valid = true;
                    }
                }

                if(!valid)
                    MessageBox.Show("Number entered is not valid.");
            }
            else {
                MessageBox.Show("Input must be all numbers and exactly 7 digits.");
            }
        }

        //Clear and Exit Buttons--------------------------------------------------------

        private void btnClear_Click(object sender, EventArgs e) {
            tbxAccountNumber.Clear();
            tbxAccountNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
