using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod4lectureLoops {
    public partial class frmMain : Form {
        int num = 0;

        public frmMain() {
            InitializeComponent();
        }

        private void btnWhileLoop_Click(object sender, EventArgs e) {
            while(num < 10) {
                lbxLoops.Items.Add(num);

                ++num;
            }

            num = 0;
        }

        private void btnDoWhileLoop_Click(object sender, EventArgs e) {
            do {
                lbxLoops.Items.Add(num);

                ++num;
            } while (num < 10);

            num = 0;
        }

        private void btnForLoop_Click(object sender, EventArgs e) {
            for(int i = 0; i < 30; i += 3) {
                lbxLoops.Items.Add(i);
            }
        }

        private void btnForEachLoop_Click(object sender, EventArgs e) {
            string[] months = {"Jan", "Feb", "Mar", "Apr"};

            foreach(string m in months) {
                lbxLoops.Items.Add(m);
            }
        }
    }
}
