using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobSmetana8A {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        //Create Car object
        Car car = new Car();

        //Accelerate and Brake Buttons--------------------------------------------------
        private void btnAccelerate_Click(object sender, EventArgs e) {
            car.Accelerate();
            lblOutput.Text = car.Speed.ToString() + " mph";
        }

        private void btnBrake_Click(object sender, EventArgs e) {
            car.Brake();
            lblOutput.Text = car.Speed.ToString() + " mph";
        }

        //Exit Button-------------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
