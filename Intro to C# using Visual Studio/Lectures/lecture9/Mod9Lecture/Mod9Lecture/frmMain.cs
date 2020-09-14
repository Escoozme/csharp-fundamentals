using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod9Lecture {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        public static string setValueForFNameText = "";
        public static string setValueForLNameText = "";

        private void btnFormTwo_Click(object sender, EventArgs e) {
            setValueForFNameText = tbxFName.Text;
            setValueForLNameText = tbxLName.Text;
            frmTwo two = new frmTwo();
            //a Modeless form
            two.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAbout about = new frmAbout();
            //a Modal form
            about.ShowDialog();
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e) {
            MessageBox.Show(new Point(e.X, e.Y).ToString());
        }
    }
}
