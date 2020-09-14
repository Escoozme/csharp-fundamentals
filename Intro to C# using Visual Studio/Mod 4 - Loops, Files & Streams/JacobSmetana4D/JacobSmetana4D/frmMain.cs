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

namespace JacobSmetana4D {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            StreamReader fileIn = File.OpenText(@"name.txt");

            //populates listbox with contents of name.txt file
            while(!fileIn.EndOfStream) {
                lbxNames.Items.Add(fileIn.ReadLine());
            }

            fileIn.Close();
        }
    }
}
