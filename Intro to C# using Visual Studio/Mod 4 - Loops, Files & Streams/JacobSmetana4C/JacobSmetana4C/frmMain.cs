using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana4C {
    public partial class frmMain : Form {
        //declares streamwriter variable
        StreamWriter fileOut;

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            //opens name.txt file for writing
            fileOut = File.AppendText(@"name.txt");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            //closes name.txt file in case Exit button is not clicked
            fileOut.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e) {
            //writes name from textbox to name.txt file
            if(tbxName.Text != "") {
                fileOut.WriteLine(tbxName.Text);
            }
            else {
                MessageBox.Show("A name must be entered.", "Error");
            }

            tbxName.Clear();
            tbxName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            //closes name.txt file and exits application
            fileOut.Close();

            Application.Exit();
        }
    }
}
