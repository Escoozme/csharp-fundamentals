using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JacobSmetana8C {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        //List for holding PersonEntry objects
        List<PersonEntry> personInfo = new List<PersonEntry>();

        //Populates list with PersonEntry objects containing data from personInfo.txt file
        //and adds names to listbox-----------------------------------------------------------------
        private void frmMain_Load(object sender, EventArgs e) {
            StreamReader fin = File.OpenText("personInfo.txt");

            for(int i = 0; !fin.EndOfStream; ++i) {
                PersonEntry person = new PersonEntry {

                    Name = fin.ReadLine(),
                    Email = fin.ReadLine(),
                    Phone = fin.ReadLine()
                };

                personInfo.Add(person);

                lbxPersons.Items.Add(personInfo[i].Name);
            }

            fin.Close();
        }

        //Display information for selected name-----------------------------------------------------
        private void lbxPersons_SelectedIndexChanged(object sender, EventArgs e) {
            int index = lbxPersons.SelectedIndex;

            lblInformation.Text = "Name: " + personInfo[index].Name + "\n";
            lblInformation.Text += "Email: " + personInfo[index].Email + "\n";
            lblInformation.Text += "Phone number: " + personInfo[index].Phone;
        }

        //Clear and Exit Buttons--------------------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e) {
            lblInformation.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
