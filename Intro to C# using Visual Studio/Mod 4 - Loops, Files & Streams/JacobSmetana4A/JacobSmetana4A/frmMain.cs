using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana4A {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            //set title for listbox
            lbxDistance.Items.Clear();
            lbxDistance.Items.Add("Hours\t\tDistance");
            lbxDistance.Items.Add("---------------------------------------------");

            try {
                int speed = int.Parse(tbxSpeed.Text), hoursTraveled = int.Parse(tbxHoursTraveled.Text);

                //populate listbox with distance traveled for every hour
                for (int i = 1; i <= hoursTraveled; ++i) {
                    lbxDistance.Items.Add(i + "\t\t" + (speed * i) + " mi.");
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
