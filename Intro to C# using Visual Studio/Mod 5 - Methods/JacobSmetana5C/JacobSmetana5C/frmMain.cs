using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace JacobSmetana5C {
    public partial class frmMain : Form {

        //initializes random number instance
        Random rand = new Random();

        //arrays for player and computer choices, [0] = computer, [1] = player
        private int[] intComputerPlayerChoice = {0, 0};
        private string[] stringComputerPlayerChoice = {"", ""};

        public frmMain() {
            InitializeComponent();
        }

        //Determines the name of the computer and player choices---------------

        private void DetermineRPS() {
            for(int i = 0; i < 2; ++i) {
                switch(intComputerPlayerChoice[i]) {
                    case 1:
                        stringComputerPlayerChoice[i] = "Rock";
                        break;
                    case 2:
                        stringComputerPlayerChoice[i] = "Paper";
                        break;
                    case 3:
                        stringComputerPlayerChoice[i] = "Scissors";
                        break;
                }
            }
        }

        //Determines winner and displays results-------------------------------

        private void DisplayResults() {
            DetermineRPS();

            lblResults.Text = "Computer: " + stringComputerPlayerChoice[0] + "   Player: " + stringComputerPlayerChoice[1] + "\n\n";

            //-2 = Rock over Scissors, 1 = Paper over Rock and Scissors over Paper
            switch(intComputerPlayerChoice[1] - intComputerPlayerChoice[0]) {
                case -2:
                case 1:
                    lblResults.Text += stringComputerPlayerChoice[1] + " beats " + stringComputerPlayerChoice[0] + "\n\n";
                    lblResults.Text += "Player Wins";
                    break;
                case 0:
                    lblResults.Text += "Both choices are the same\n\n";
                    lblResults.Text += "Draw";
                    break;
                default:
                    lblResults.Text += stringComputerPlayerChoice[0] + " beats " + stringComputerPlayerChoice[1] + "\n\n";
                    lblResults.Text += "Computer Wins";
                    break;
            }
        }

        //Determines first computer choice on load-----------------------------

        private void frmMain_Load(object sender, EventArgs e) {
            intComputerPlayerChoice[0] = rand.Next(3) + 1;
        }

        //Rock, Paper, and Scissors Buttons for player-------------------------

        private void btnRock_Click(object sender, EventArgs e) {
            //player chooses rock
            if(lblResults.Text == "") {
                intComputerPlayerChoice[1] = 1;
                DisplayResults();
            }
        }

        private void btnPaper_Click(object sender, EventArgs e) {
            //playerer chooses paper
            if(lblResults.Text == "") {
                intComputerPlayerChoice[1] = 2;
                DisplayResults();
            }
        }

        private void btnScissors_Click(object sender, EventArgs e) {
            //player chooses scissors
            if(lblResults.Text == "") {
                intComputerPlayerChoice[1] = 3;
                DisplayResults();
            }
        }

        //Play Again Button----------------------------------------------------

        private void btnPlayAgain_Click(object sender, EventArgs e) {
            //new random choice for computer and clears results label
            intComputerPlayerChoice[0] = rand.Next(3) + 1;
            lblResults.Text = string.Empty;
        }

        //Clear and Exit Buttons-----------------------------------------------

        private void btnClear_Click(object sender, EventArgs e) {
            lblResults.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
