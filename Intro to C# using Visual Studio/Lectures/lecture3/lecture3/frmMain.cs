using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture3 {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            tbxHoursWorked.Clear();
            tbxPayRate.Clear();
            lblGPOutput.Text = "";
            tbxTeam.Clear();

            tbxHoursWorked.Focus();
        }

        private void btnCalcGP_Click(object sender, EventArgs e) {
            const decimal BASE_HOURS = 40m;
            const decimal OT_RATE_MULT = 1.5m;
            const decimal OT2_RATE_MULT = 2.5m;
            const decimal OT3_RATE_MULT = 3.5m;

            decimal hoursWorked, payRate;

            if(decimal.TryParse(tbxHoursWorked.Text, out hoursWorked) && decimal.TryParse(tbxPayRate.Text, out payRate)) {
                decimal grossPay;
                decimal regPay;
                decimal overtimeHours;
                decimal overtimePay;

                string lucky = "Purple";

                if (hoursWorked > BASE_HOURS) {  //overtime pay
                    regPay = BASE_HOURS * payRate;

                    overtimeHours = hoursWorked - BASE_HOURS;

                    if (hoursWorked > 60) {  //60+ overtime hours
                        overtimePay = overtimeHours * payRate * OT3_RATE_MULT;
                    }
                    else if (hoursWorked > 50) { //51-60 overtime hours
                        overtimePay = overtimeHours * payRate * OT2_RATE_MULT;
                    }
                    else {  //41-50 overtime hours
                        overtimePay = overtimeHours * payRate * OT_RATE_MULT;
                    }

                    grossPay = overtimePay + regPay;
                }
                else {  //pay without overtime
                    grossPay = hoursWorked * payRate;
                }

                lblGPOutput.Text = grossPay.ToString("C");

                if (hoursWorked > 50 && tbxTeam.Text == "Red") {
                    MessageBox.Show("Meeting Monday at 4:40pm.");
                }
                else if (hoursWorked > 60 || tbxTeam.Text == "Blue") {
                    MessageBox.Show("Meeting Tuesday at 6:00pm.");
                }
                else if (!(hoursWorked > 40 && hoursWorked < 50) && lucky == "Purple") {
                    MessageBox.Show("Meeting 8:00am on Friday.");
                }
                else {
                    MessageBox.Show("No meeting. You get a 2% raise.");
                }
            }
            else {
                MessageBox.Show("Please enter correct values in the boxes.");

                tbxHoursWorked.Clear();
                tbxPayRate.Clear();
                tbxHoursWorked.Focus();
            }

            //try {
            //    //constants
            //    const decimal BASE_HOURS = 40m;
            //    const decimal OT_RATE_MULT = 1.5m;
            //    const decimal OT2_RATE_MULT = 2.5m;
            //    const decimal OT3_RATE_MULT = 3.5m;

            //    decimal hoursWorked = decimal.Parse(tbxHoursWorked.Text);
            //    decimal payRate = decimal.Parse(tbxPayRate.Text);
            //    decimal grossPay;
            //    decimal regPay;
            //    decimal overtimeHours;
            //    decimal overtimePay;

            //    string lucky = "Purple";

            //    if(hoursWorked > BASE_HOURS) {  //overtime pay
            //        regPay = BASE_HOURS * payRate;

            //        overtimeHours = hoursWorked - BASE_HOURS;

            //        if(hoursWorked > 60) {  //60+ overtime hours
            //            overtimePay = overtimeHours * payRate * OT3_RATE_MULT;
            //        }
            //        else if(hoursWorked > 50) { //51-60 overtime hours
            //            overtimePay = overtimeHours * payRate * OT2_RATE_MULT;
            //        }
            //        else {  //41-50 overtime hours
            //            overtimePay = overtimeHours * payRate * OT_RATE_MULT;
            //        }

            //        grossPay = overtimePay + regPay;
            //    }
            //    else {  //pay without overtime
            //        grossPay = hoursWorked * payRate;
            //    }

            //    lblGPOutput.Text = grossPay.ToString("C");

            //    if(hoursWorked > 50 && tbxTeam.Text == "Red") {
            //        MessageBox.Show("Meeting Monday at 4:40pm.");
            //    }
            //    else if(hoursWorked > 60 || tbxTeam.Text == "Blue") {
            //        MessageBox.Show("Meeting Tuesday at 6:00pm.");
            //    }
            //    else if(!(hoursWorked > 40 && hoursWorked < 50) && lucky == "Purple") {
            //        MessageBox.Show("Meeting 8:00am on Friday.");
            //    }
            //    else {
            //        MessageBox.Show("No meeting. You get a 2% raise.");
            //    }
            //}
            //catch(Exception ex) {
            //    MessageBox.Show(ex.Message);
            //}
        }

        //private void radFemale_CheckedChanged(object sender, EventArgs e) {
        //    if(radFemale.Checked == true) {
        //        MessageBox.Show("45 female employees");
        //        radFemale.Checked = false;
        //    }
        //}

        //private void radMale_CheckedChanged(object sender, EventArgs e) {
        //    if (radMale.Checked == true) {
        //        MessageBox.Show("69 male employees");
        //        radMale.Checked = false;
        //    }
        //}

        private void btnOk_Click(object sender, EventArgs e) {
            int month = int.Parse(tbxMonth.Text);
            string position;

            switch(month) {
                case 1:
                    MessageBox.Show("January");
                    break;
                case 2:
                    MessageBox.Show("February");
                    break;
                case 3:
                    MessageBox.Show("March");
                    break;
                default:
                    MessageBox.Show("Error: Invalid entry.");
                    break;
            }

            if(lbxPositions.SelectedIndex != -1) {
                position = lbxPositions.SelectedItem.ToString();
                MessageBox.Show("this is my position: " + position);
            }
            else {
                MessageBox.Show("Please select a position...");
            }

            if(radFemale.Checked == true) {
                MessageBox.Show("45 female employees");
            }
            else if(radMale.Checked == true) {
                MessageBox.Show("69 male employees");
            }
            else {
                MessageBox.Show("We're in trouble. No one works here.");
            }

            if(cbxRed.Checked && cbxBlue.Checked) {
                this.BackColor = Color.Purple;
            }
            else if(cbxBlue.Checked) {
                this.BackColor = Color.Blue;
            }
            else if(cbxRed.Checked){
                this.BackColor = Color.Red;
            }
        }
    }
}
