using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetanaTest2A {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        //Initialize random instance and declare variables
        Random rand = new Random();
        int firstNum, secondNum, sum;

        //Initial problem created on form load------------------------------------------

        private void frmMain_Load(object sender, EventArgs e) {
            firstNum = rand.Next(100) + 1;
            secondNum = rand.Next(100) + 1;
            sum = firstNum + secondNum;

            lblProblem.Text = firstNum + " + " + secondNum;
        }

        //Button to generate new problem when clicked-----------------------------------

        private void btnNewProblem_Click(object sender, EventArgs e) {
            firstNum = rand.Next(100) + 1;
            secondNum = rand.Next(100) + 1;
            sum = firstNum + secondNum;

            lblProblem.Text = firstNum + " + " + secondNum;

            tbxUserAnswer.Clear();
        }

        //Button to check if user's answer to problem is correct------------------------

        private void btnCheckResult_Click(object sender, EventArgs e) {
            try {
                int userAnwser = int.Parse(tbxUserAnswer.Text);

                if(userAnwser == sum)
                    MessageBox.Show("Correct.");
                else
                    MessageBox.Show("Incorrect.");
            }
            catch {
                MessageBox.Show("Input must be an integer.");
                tbxUserAnswer.Clear();
                tbxUserAnswer.Focus();
            }
        }

        //Clear and Exit Buttons--------------------------------------------------------

        private void btnClear_Click(object sender, EventArgs e) {
            lblProblem.Text = string.Empty;
            tbxUserAnswer.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
