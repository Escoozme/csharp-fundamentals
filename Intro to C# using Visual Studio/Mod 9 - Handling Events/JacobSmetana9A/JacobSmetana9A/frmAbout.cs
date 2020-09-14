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
    public partial class frmAbout : Form {
        public frmAbout() {
            InitializeComponent();
        }

        //Show mouse coordinates on mouse click
        private void frmAbout_MouseClick(object sender, MouseEventArgs e) {
            MessageBox.Show(new Point(e.X, e.Y).ToString());
        }

        //Close About form
        private void btnOK_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
