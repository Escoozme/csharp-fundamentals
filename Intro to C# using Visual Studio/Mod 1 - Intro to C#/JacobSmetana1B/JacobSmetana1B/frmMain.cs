using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana1B {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnJoke_Click(object sender, EventArgs e) {
            lblJoke.Text = "What has four wheels and flies?"; //The joke
        }

        private void btnPunchLine_Click(object sender, EventArgs e) {
            if(lblJoke.Text != "") {
                lblJoke.Text = "A garbage truck :)"; //The punchline
            }
        }
    }
}
