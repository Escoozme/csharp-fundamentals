using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana3C {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            //both listboxes need an item selected
            if(lbxWorkshop.SelectedIndex != -1 && lbxLocation.SelectedIndex != -1) {
                decimal numberOfDays = 0, registrationFee = 0, lodgingFee = 0;

                //determines number of days and registration fee
                switch (lbxWorkshop.SelectedIndex) {
                    case 0:
                        numberOfDays = 3; registrationFee = 1000;
                        break;
                    case 1:
                        numberOfDays = 3; registrationFee = 800;
                        break;
                    case 2:
                        numberOfDays = 3; registrationFee = 1500;
                        break;
                    case 3:
                        numberOfDays = 5; registrationFee = 1300;
                        break;
                    case 4:
                        numberOfDays = 1; registrationFee = 500;
                        break;
                }

                //determines lodging fee for 1 day
                switch(lbxLocation.SelectedIndex) {
                    case 0:
                        lodgingFee = 150;
                        break;
                    case 1:
                        lodgingFee = 225;
                        break;
                    case 2:
                        lodgingFee = 175;
                        break;
                    case 3:
                        lodgingFee = 300;
                        break;
                    case 4:
                        lodgingFee = 175;
                        break;
                    case 5:
                        lodgingFee = 150;
                        break;
                }

                //determines total lodging fee
                lodgingFee *= numberOfDays;

                //displays registration fee, lodging fee, and total fee
                lblTotalCost.Text = "Registration:  " + registrationFee.ToString("C") + "\n\n" +
                                    "Lodging:       " + lodgingFee.ToString("C") + "\n\n" +
                                    "Total:         " + (registrationFee + lodgingFee).ToString("C");
            }
        }
    }
}
