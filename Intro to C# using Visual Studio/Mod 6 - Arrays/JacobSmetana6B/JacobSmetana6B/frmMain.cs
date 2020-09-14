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

namespace JacobSmetana6B {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        //List for holding names of World Series winners-------------------------
        List<string> worldSeriesWinners = new List<string>();

        //Populate listbox with data from Teams.txt on load----------------------
        //Populate List with data from WorldSeriesWinners.txt on load------------

        private void frmMain_Load(object sender, EventArgs e) {
            StreamReader fin = File.OpenText("Teams.txt");

            while(!fin.EndOfStream)
                lbxTeams.Items.Add(fin.ReadLine());

            fin.Close();

            fin = File.OpenText("WorldSeriesWinners.txt");

            while(!fin.EndOfStream)
                worldSeriesWinners.Add(fin.ReadLine());

            fin.Close();
        }

        //Displays selected team name and number of wins-------------------------

        private void lbxTeams_SelectedIndexChanged(object sender, EventArgs e) {
            int count = 0;

            foreach(string team in worldSeriesWinners)
                if(team == (string)lbxTeams.SelectedItem)
                    ++count;
            
            lblWorldSeriesWins.Text = (string)lbxTeams.SelectedItem + "\n\n";
            lblWorldSeriesWins.Text += "Wins: " + count;
        }

        //Exit Button------------------------------------------------------------

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
