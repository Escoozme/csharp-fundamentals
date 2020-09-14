using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana5A {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private bool ValidateTextboxes() {
            //validate numeric values in textboxes
            decimal cost, markup;

            if(decimal.TryParse(tbxWholesaleCost.Text, out cost) && decimal.TryParse(tbxMarkupPercentage.Text, out markup))
                return true;
            else
                return false;
        }

        private decimal CalculateRetail(decimal cost, decimal markup) {
            //calculates retail cost by multiplying wholesale cost by markup percentage
            decimal retail = cost * markup;

            return retail;
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            if(ValidateTextboxes()) {
                decimal wholesaleCost = decimal.Parse(tbxWholesaleCost.Text);
                decimal markupPercentage = decimal.Parse(tbxMarkupPercentage.Text) / 100 + 1;
                //invokes the CalculateRetail method to get the retail price of an item
                decimal retailPrice = CalculateRetail(wholesaleCost, markupPercentage);

                //displays retail price
                lblRetailPrice.Text = retailPrice.ToString("C");
            }
            else
                MessageBox.Show("One or both textboxes has incorrect input.");
        }

        private void btnClear_Click(object sender, EventArgs e) {
            //clear textboxes and label
            tbxWholesaleCost.Clear();
            tbxMarkupPercentage.Clear();
            lblRetailPrice.Text = string.Empty;
            tbxWholesaleCost.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
