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

namespace JacobSmetana6A {
    public partial class frmMain : Form {

        //array to hold sales figures
        private decimal[] salesFigures;

        public frmMain() {
            InitializeComponent();
        }

        //Methods somewhere in the program---------------------------------

        private decimal calcTotal(decimal[] decArray) {
            decimal total = 0;

            foreach(decimal num in decArray)
                total += num;

            return total;
        }

        private decimal calcAverage(decimal num) {
            return num / salesFigures.Length;
        }

        //Populates array with data from Sales.txt on load-----------------

        private void frmMain_Load(object sender, EventArgs e) {
            StreamReader fin = File.OpenText("Sales.txt");

            //determine size of array
            int arrSize = 0;

            while(!fin.EndOfStream) {
                fin.ReadLine();
                ++arrSize;
            }

            salesFigures = new decimal[arrSize];

            //put data into array and listbox
            fin = new StreamReader("Sales.txt");

            for(int i = 0; !fin.EndOfStream; ++i) {
                decimal.TryParse(fin.ReadLine(), out salesFigures[i]);
                lbxValues.Items.Add(salesFigures[i]);
            }

            fin.Close();
        }

        //Sales and Exit buttons-------------------------------------------

        private void btnSales_Click(object sender, EventArgs e) {
            //invokes methods for getting total and average values
            decimal totalValue = calcTotal(salesFigures);
            decimal averageValue = calcAverage(totalValue);

            //sorts array for finding smallest and largest values
            Array.Sort(salesFigures);

            //output
            lblTotal.Text = totalValue.ToString("C2");
            lblAverage.Text = averageValue.ToString("C2");
            lblLargest.Text = salesFigures[salesFigures.Length - 1].ToString("C2");
            lblSmallest.Text = salesFigures[0].ToString("C2");
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
