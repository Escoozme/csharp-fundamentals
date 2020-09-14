using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana5B {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        //Method for validating numeric values in textboxes----------

        private bool ValidateTextboxes() {
            decimal parts, labor;

            if(decimal.TryParse(tbxPartsCost.Text, out parts) && decimal.TryParse(tbxLabor.Text, out labor))
                return true;
            else
                return false;
        }

        //Calculate Button-------------------------------------------

        private decimal OilLubeCharges() {
            //returns sum of oil and lube charges
            decimal oil = 0, lube = 0;

            if(cbxOilChange.Checked)
                oil = 26;
            if(cbxLubeJob.Checked)
                lube = 18;

            return oil + lube;
        }

        private decimal FlushCharges() {
            //returns sum of radiator and transmission flush charges
            decimal radFlush = 0, transFlush = 0;

            if(cbxRadiatorFlush.Checked)
                radFlush = 30;
            if(cbxTransmissionFlush.Checked)
                transFlush = 80;

            return radFlush + transFlush;
        }

        private decimal MiscCharges() {
            //returns sum of inspection, muffler replacement, and tire rotation charges
            decimal inspection = 0, muffler = 0, tireRotation = 0;

            if(cbxInspection.Checked)
                inspection = 15;
            if(cbxReplaceMuffler.Checked)
                muffler = 100;
            if(cbxTireRotation.Checked)
                tireRotation = 20;

            return inspection + muffler + tireRotation;
        }

        private decimal OtherCharges() {
            //returns sum of cost of parts and labor charges
            return decimal.Parse(tbxPartsCost.Text) + decimal.Parse(tbxLabor.Text);
        }

        private decimal TaxCharges() {
            //returns tax on parts
            decimal salesTax = 0.06m;

            return decimal.Parse(tbxPartsCost.Text) * salesTax;
        }

        private decimal TotalCharges() {
            //returns total charges
            return OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            //validates textboxes before calculating charges
            if(ValidateTextboxes()) {
                lblServicesAndLabor.Text = (OilLubeCharges() + FlushCharges() + MiscCharges() + decimal.Parse(tbxLabor.Text)).ToString("C");
                lblPartsCost.Text = decimal.Parse(tbxPartsCost.Text).ToString("C");
                lblTaxOnParts.Text = TaxCharges().ToString("C");
                lblTotalFees.Text = TotalCharges().ToString("C");
            }
            else
                MessageBox.Show("One or both textboxes has incorrect input.");
        }

        //Clear Button-----------------------------------------------

        private void ClearOilLube() {
            cbxOilChange.Checked = false;
            cbxLubeJob.Checked = false;
        }

        private void ClearFlushes() {
            cbxRadiatorFlush.Checked = false;
            cbxTransmissionFlush.Checked = false;
        }

        private void ClearMisc() {
            cbxInspection.Checked = false;
            cbxReplaceMuffler.Checked = false;
            cbxTireRotation.Checked = false;
        }

        private void ClearOther() {
            tbxPartsCost.Clear();
            tbxLabor.Clear();
        }

        private void ClearFees() {
            lblServicesAndLabor.Text = string.Empty;
            lblPartsCost.Text = string.Empty;
            lblTaxOnParts.Text = string.Empty;
            lblTotalFees.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            //calls all methods which uncheck checkboxes and clears textboxes and labels
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        //Exit Button------------------------------------------------

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
