using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana9A {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        //Movie Menu Buttons-------------------------------------------------------------
        private void theThingToolStripMenuItem_Click(object sender, EventArgs e) {
            frmMovie1 theThing = new frmMovie1();
            theThing.ShowDialog();
        }

        private void alienToolStripMenuItem_Click(object sender, EventArgs e) {
            frmMovie2 alien = new frmMovie2();
            alien.ShowDialog();
        }

        private void purpleToolStripMenuItem1_Click(object sender, EventArgs e) {
            frmMovie3 predator = new frmMovie3();
            predator.ShowDialog();
        }

        //Background Color Menu Buttons--------------------------------------------------
        private void redToolStripMenuItem_Click(object sender, EventArgs e) {
            this.BackColor = Color.IndianRed;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e) {
            this.BackColor = Color.LightGreen;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e) {
            this.BackColor = Color.LightBlue;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e) {
            this.BackColor = Color.Purple;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e) {
            this.BackColor = Color.LightYellow;
        }

        //About Button-------------------------------------------------------------------
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAbout about = new frmAbout();
            about.Show();
        }

        //Exit Button--------------------------------------------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
