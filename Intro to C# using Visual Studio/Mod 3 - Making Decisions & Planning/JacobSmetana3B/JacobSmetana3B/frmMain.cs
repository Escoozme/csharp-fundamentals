using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana3B {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            try {
                int numBooks = int.Parse(tbxBooks.Text);

                //Determine number of points on number of books purchased
                switch (numBooks) {
                    case 0:
                        lblPointsEarned.Text = "0";
                        break;
                    case 1:
                        lblPointsEarned.Text = "5";
                        break;
                    case 2:
                        lblPointsEarned.Text = "15";
                        break;
                    case 3:
                        lblPointsEarned.Text = "30";
                        break;
                    default:
                        lblPointsEarned.Text = "60";
                        break;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

            tbxBooks.Clear();
            tbxBooks.Focus();
        }
    }
}
