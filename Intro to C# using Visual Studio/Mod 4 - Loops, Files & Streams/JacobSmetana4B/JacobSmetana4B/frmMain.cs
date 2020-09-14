using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana4B {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e) {
            //set title of listbox
            lbxPopulation.Items.Clear();
            lbxPopulation.Items.Add("Day\t\tApprox. Population");
            lbxPopulation.Items.Add("------------------------------------------------------------");

            try {
                double numOfOrganisms = double.Parse(tbxStartingNumber.Text);
                double percentIncrease = double.Parse(tbxPercentIncrease.Text) / 100 + 1;
                int daysToMultiply = int.Parse(tbxDaysToMultiply.Text);

                //loop control variable
                int counter = 1;

                while(counter <= daysToMultiply) {
                    //output new total number of organisms for each day
                    if(numOfOrganisms.ToString().Length >= 8)
                        lbxPopulation.Items.Add(counter + "\t\t" + numOfOrganisms.ToString("n6"));
                    else
                        lbxPopulation.Items.Add(counter + "\t\t" + numOfOrganisms);

                    //multiply current number of organisms by % increase
                    numOfOrganisms *= percentIncrease;

                    ++counter;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
