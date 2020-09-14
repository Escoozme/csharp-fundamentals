using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod8LectureStarter {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        //The GetCarData method accepts a CarDetails object as an argument. It assigns the data entered by the user to the object's properties
        private void GetCarData(CarDetails vehicle) {
            //get the car's make and model
            vehicle.Make = tbxMake.Text;
            vehicle.Model = tbxModel.Text;

            //get the car's price
            decimal price;

            if(decimal.TryParse(tbxPrice.Text, out price))
                vehicle.Price = price;
            else {
                MessageBox.Show("Invalid price entered.");
                tbxPrice.Clear(); tbxPrice.Focus();
            }
        }

        //Create a List with the class object
        List<CarDetails> lstInventory = new List<CarDetails>();

        private void GetCarData2(CarDetails vehicle) {
            //get the car's make and model
            vehicle.Make = tbxMake2.Text;
            vehicle.Model = tbxModel2.Text;

            //get the car's price
            decimal price;

            if(decimal.TryParse(tbxPrice2.Text, out price))
                vehicle.Price = price;
            else
                MessageBox.Show("Invalid price entered.");
        }


        //Toss Coin Button------------------------------------------------------------------------------

        private void btnToss_Click(object sender, EventArgs e) {
            //Create a Coin object -> declaring a variable
            Coin myCoin = new Coin();

            lbxOutput.Items.Clear();

            //Toss the coin five times
            for(int i = 0; i < 5; ++i) {
                myCoin.Toss();
                lbxOutput.Items.Add(myCoin.GetSideUp());
            }
        }

        //Create Object Button-------------------------------------------------------------------------

        private void btnCreateObject_Click(object sender, EventArgs e) {
            //Create a CarDetails object
            CarDetails myCar = new CarDetails();

            //get the car data
            GetCarData(myCar);

            //display the car data
            lblMake.Text = myCar.Make;
            lblModel.Text = myCar.Model;
            lblPrice.Text = myCar.Price.ToString("C2");
        }

        //Enter Inventory Button------------------------------------------------------------------------

        private void btnEnterInv_Click(object sender, EventArgs e) {
            //create a CarDetails object
            CarDetails myCar = new CarDetails();

            //get the car data
            GetCarData2(myCar);

            //add the car data to the List lstInventory
            lstInventory.Add(myCar);

            //add an entry to the listbox
            lbxCarInventory.Items.Add(myCar.Make + " " + myCar.Model);

            //clear the textbox controls and reset focus
            tbxMake2.Clear(); tbxModel2.Clear(); tbxPrice2.Clear();

            tbxMake2.Focus();
        }

        private void lbxCarInventory_SelectedIndexChanged(object sender, EventArgs e) {
            //get the index of the selected item
            int index = lbxCarInventory.SelectedIndex;

            //display the selected item's price
            MessageBox.Show(lstInventory[index].Price.ToString("C2"));
        }

        //Exit Button-----------------------------------------------------------------------------------

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
