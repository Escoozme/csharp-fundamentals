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

namespace mod4lectureFileStreams {
    public partial class frmMain : Form {
        private double totalPoints = 0;
        private int numOfPlayers;
        private string playerName, playerPoints;

        private void frmMain_Load(object sender, EventArgs e) {
            try {
                string fullName;
                int points;

                //open file
                StreamReader fileIn = File.OpenText(@"Team.txt");

                //set title for listbox
                lbxPlayerPoints.Items.Add("Name\t\t  Points");

                //reads name and points from text file to listbox
                while(!fileIn.EndOfStream) {
                    fullName = fileIn.ReadLine();

                    if(int.TryParse(fileIn.ReadLine(), out points)) {
                        totalPoints += points;

                        if(fullName.Length < 16)
                            lbxPlayerPoints.Items.Add(fullName + "\t  " + points);
                        else
                            lbxPlayerPoints.Items.Add(fullName + "  " + points);

                    }
                    else {
                        MessageBox.Show("Data not a number","Error");
                    }
                }

                lblTotalTeamPoints.Text = totalPoints.ToString();

                //close file
                fileIn.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            try {
                StreamWriter fileOut = File.AppendText(@"Team.txt");

                fileOut.WriteLine(playerName);
                fileOut.WriteLine(playerPoints);
                fileOut.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message + "Date not saved");
            }

            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            int points;

            if(int.TryParse(tbxPointsScored.Text, out points)) {
                if(lbxPlayerPoints.Items.Count == 0) {
                    totalPoints = points;
                }
                else {
                    totalPoints += points;
                }

                lbxPlayerPoints.Items.Add(tbxFullName.Text + "\t" + tbxPointsScored.Text);
            }
            else {
                MessageBox.Show("Not a number");
                tbxPointsScored.Clear();
                tbxPointsScored.Focus();
            }

            lblTotalTeamPoints.Text = totalPoints.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(lbxPlayerPoints.Items.Count != 0) {
                try {
                    StreamWriter fileOut;

                    int count = lbxPlayerPoints.Items.Count;

                    if (sfdSave.ShowDialog() == DialogResult.OK) {
                        fileOut = File.CreateText(sfdSave.FileName);

                        for(int j = 0; j < count; ++j) {
                            fileOut.WriteLine(lbxPlayerPoints.Items[j].ToString());
                        }

                        fileOut.Close();
                        MessageBox.Show("Data saved");
                    }
                    else {
                        MessageBox.Show("Data NOT saved");
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        public frmMain() {
            InitializeComponent();
        }
    }
}
