using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetanaTest1A {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnBlue_Click(object sender, EventArgs e) {
            //translates "Azul" to "Blue"
            lblTranslation.Text = "Blue";
            BackColor = Color.LightBlue;
        }

        private void btnRed_Click(object sender, EventArgs e) {
            //translates "Rojo" to "Red"
            lblTranslation.Text = "Red";
            BackColor = Color.IndianRed;
        }

        private void btnGreen_Click(object sender, EventArgs e) {
            //translates "Verde" to "Green"
            lblTranslation.Text = "Green";
            BackColor = Color.PaleGreen;
        }

        private void btnYellow_Click(object sender, EventArgs e) {
            //translates "Amarillo" to "Yellow"
            lblTranslation.Text = "Yellow";
            BackColor = Color.LightYellow;
        }

        private void btnPurple_Click(object sender, EventArgs e) {
            //translates "Morado" "Purple"
            lblTranslation.Text = "Purple";
            BackColor = Color.MediumPurple;
        }
    }
}
