using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana1A {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            lblTranslation.Text = "Left"; //translates "la gauche" to "left"
        }

        private void btnMiddle_Click(object sender, EventArgs e) {
            lblTranslation.Text = "Middle"; //translates "milieu" to "middle"
        }

        private void btnRight_Click(object sender, EventArgs e) {
            lblTranslation.Text = "Right"; //translates "droit" to "right"
        }
    }
}
