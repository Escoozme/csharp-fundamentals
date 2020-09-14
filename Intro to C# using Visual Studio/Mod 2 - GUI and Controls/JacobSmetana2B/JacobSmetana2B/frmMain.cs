using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana2B {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            //clears output label and changes form background color to green
            //and resets background color of buttons
            lblOutput.Text = "";

            btnUpperA.BackColor = DefaultBackColor;
            btnLowerA.BackColor = DefaultBackColor;
            btnUpperAn.BackColor = DefaultBackColor;
            btnLowerAn.BackColor = DefaultBackColor;
            btnUpperThe.BackColor = DefaultBackColor;
            btnLowerThe.BackColor = DefaultBackColor;
            btnAnd.BackColor = DefaultBackColor;
            btnIt.BackColor = DefaultBackColor;
            btnMan.BackColor = DefaultBackColor;
            btnWoman.BackColor = DefaultBackColor;
            btnDog.BackColor = DefaultBackColor;
            btnCat.BackColor = DefaultBackColor;
            btnCar.BackColor = DefaultBackColor;
            btnBicycle.BackColor = DefaultBackColor;
            btnBeautiful.BackColor = DefaultBackColor;
            btnBig.BackColor = DefaultBackColor;
            btnSmall.BackColor = DefaultBackColor;
            btnStrange.BackColor = DefaultBackColor;
            btnRanOver.BackColor = DefaultBackColor;
            btnLookedAt.BackColor = DefaultBackColor;
            btnRode.BackColor = DefaultBackColor;
            btnSpokeTo.BackColor = DefaultBackColor;
            btnLaughedAt.BackColor = DefaultBackColor;
            btnDrove.BackColor = DefaultBackColor;
            btnSpace.BackColor = DefaultBackColor;
            btnPeriod.BackColor = DefaultBackColor;
            btnExclamationPoint.BackColor = DefaultBackColor;
            btnQuestionMark.BackColor = DefaultBackColor;

            BackColor = Color.PaleGreen;
        }

        private void btnUpperA_Click(object sender, EventArgs e) {
            //adds "A" to output
            lblOutput.Text += "A";

            btnUpperA.BackColor = Color.LightBlue;
        }

        private void btnLowerA_Click(object sender, EventArgs e) {
            //adds "a" to output
            lblOutput.Text += "a";

            btnLowerA.BackColor = Color.LightBlue;
        }

        private void btnUpperAn_Click(object sender, EventArgs e) {
            //adds "An" to output
            lblOutput.Text += "An";

            btnUpperAn.BackColor = Color.LightBlue;
        }

        private void btnLowerAn_Click(object sender, EventArgs e) {
            //adds "an" to output
            lblOutput.Text += "an";

            btnLowerAn.BackColor = Color.LightBlue;
        }

        private void btnUpperThe_Click(object sender, EventArgs e) {
            //adds "The" to output
            lblOutput.Text += "The";

            btnUpperThe.BackColor = Color.LightBlue;
        }

        private void btnLowerThe_Click(object sender, EventArgs e) {
            //adds "the" to output
            lblOutput.Text += "the";

            btnLowerThe.BackColor = Color.LightBlue;
        }

        private void btnAnd_Click(object sender, EventArgs e) {
            //adds "and" to output
            lblOutput.Text += "and";

            btnAnd.BackColor = Color.LightBlue;
        }

        private void btnIt_Click(object sender, EventArgs e) {
            //adds "it" to output
            lblOutput.Text += "it";

            btnIt.BackColor = Color.LightBlue;
        }

        private void btnMan_Click(object sender, EventArgs e) {
            //adds "man" to output
            lblOutput.Text += "man";

            btnMan.BackColor = Color.LightBlue;
        }

        private void btnWoman_Click(object sender, EventArgs e) {
            //adds "woman" to output
            lblOutput.Text += "woman";

            btnWoman.BackColor = Color.LightBlue;
        }

        private void btnDog_Click(object sender, EventArgs e) {
            //adds "dog" to output
            lblOutput.Text += "dog";

            btnDog.BackColor = Color.LightBlue;
        }

        private void btnCat_Click(object sender, EventArgs e) {
            //adds "cat" to output
            lblOutput.Text += "cat";

            btnCat.BackColor = Color.LightBlue;
        }

        private void btnCar_Click(object sender, EventArgs e) {
            //adds "car" to output
            lblOutput.Text += "car";

            btnCar.BackColor = Color.LightBlue;
        }

        private void btnBicycle_Click(object sender, EventArgs e) {
            //adds "bicycle" to output
            lblOutput.Text += "bicycle";

            btnBicycle.BackColor = Color.LightBlue;
        }

        private void btnBeautiful_Click(object sender, EventArgs e) {
            //adds "beautiful" to output
            lblOutput.Text += "beautiful";

            btnBeautiful.BackColor = Color.LightBlue;
        }

        private void btnBig_Click(object sender, EventArgs e) {
            //adds "big" to output
            lblOutput.Text += "big";

            btnBig.BackColor = Color.LightBlue;
        }

        private void btnSmall_Click(object sender, EventArgs e) {
            //adds "small" to output
            lblOutput.Text += "small";

            btnSmall.BackColor = Color.LightBlue;
        }

        private void btnStrange_Click(object sender, EventArgs e) {
            //adds "strange" to output
            lblOutput.Text += "strange";

            btnStrange.BackColor = Color.LightBlue;
        }

        private void btnRanOver_Click(object sender, EventArgs e) {
            //adds "ran over" to output
            lblOutput.Text += "ran over";

            btnRanOver.BackColor = Color.LightBlue;
        }

        private void btnLookedAt_Click(object sender, EventArgs e) {
            //adds "looked at" to output
            lblOutput.Text += "looked at";

            btnLookedAt.BackColor = Color.LightBlue;
        }

        private void btnRode_Click(object sender, EventArgs e) {
            //adds "rode" to output
            lblOutput.Text += "rode";

            btnRode.BackColor = Color.LightBlue;
        }

        private void btnSpokeTo_Click(object sender, EventArgs e) {
            //adds "spoke to" to output
            lblOutput.Text += "spoke to";

            btnSpokeTo.BackColor = Color.LightBlue;
        }

        private void btnLaughedAt_Click(object sender, EventArgs e) {
            //adds "laughed at" to output
            lblOutput.Text += "laughed at";

            btnLaughedAt.BackColor = Color.LightBlue;
        }

        private void btnDrove_Click(object sender, EventArgs e) {
            //adds "drove" to output
            lblOutput.Text += "drove";

            btnDrove.BackColor = Color.LightBlue;
        }

        private void btnSpace_Click(object sender, EventArgs e) {
            //adds a space to output
            lblOutput.Text += " ";

            btnSpace.BackColor = Color.LightBlue;
        }

        private void btnPeriod_Click(object sender, EventArgs e) {
            //adds a period to output
            lblOutput.Text += ".";

            btnPeriod.BackColor = Color.LightBlue;
        }

        private void btnExclamationPoint_Click(object sender, EventArgs e) {
            //adds an exclamation point to output
            lblOutput.Text += "!";

            btnExclamationPoint.BackColor = Color.LightBlue;
        }

        private void btnQuestionMark_Click(object sender, EventArgs e) {
            //adds a question mark to output
            lblOutput.Text += "?";

            btnQuestionMark.BackColor = Color.LightBlue;
        }
    }
}
