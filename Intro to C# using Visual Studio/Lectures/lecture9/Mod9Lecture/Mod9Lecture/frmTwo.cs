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
    public partial class frmTwo : Form {
        public frmTwo() {
            InitializeComponent();
        }

        private void frmTwo_Load(object sender, EventArgs e) {
            lblFullName.Text = frmMain.setValueForFNameText + " " + frmMain.setValueForLNameText;
        }

        private void btnReturn_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
