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

namespace Lecture7 {
    public partial class frmMain : Form {

        //sets size of the array
        private const int SIZE = 3;
        private int[] numArray = new int[SIZE];

        public frmMain() {
            InitializeComponent();
        }

        //methods

        private void ArraysToList(int[] intArray) {
            foreach(int value in intArray)
                lbxNumbers2Array.Items.Add(value);
        }

        private int SequentialSearch(string[] strArray, string strValue) {
            bool found = false;
            int index = 0, pos = -1;

            while(!found && index <strArray.Length) {
                if(strArray[index] == strValue) {
                    found = true;
                    pos = index;
                }

                ++index;
            }

            return pos;
        }

        private void AppendFile() {
            try {
                StreamWriter fileOut = File.AppendText("GirlNames.txt");

                fileOut.WriteLine(txtEnterGirlName.Text);

                fileOut.Close();

                MessageBox.Show("Name saved to the file and file closed.");

                lbxGirlNames.Items.Add(txtEnterGirlName.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveOnExit() {
            try {
                StreamWriter fileOut = File.CreateText("GirlNames.txt");

                foreach(string str in gNamesList)
                    fileOut.WriteLine(str);
                
                fileOut.Close();

                MessageBox.Show("File closed and data saved.");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //Events
        private void btnSetEachElement_Click(object sender, EventArgs e) {
            //assigns variable name and its size
            string[] names = new string[SIZE];

            //assign names to each element
            names[0] = "Fred";
            names[1] = "Jane";
            names[2] = "Simone";

            MessageBox.Show("1st Name of array:  " + names[0]);
            MessageBox.Show("2nd Name of array:  " + names[1]);
            MessageBox.Show("3rd Name of array:  " + names[2]);
        }

        private void btnTxtElement_Click(object sender, EventArgs e) {
          
            //assign numbers from text box and validate

            if(int.TryParse(txtNum1.Text, out numArray[0])) {
                MessageBox.Show("1st number of array:  " + numArray[0]);
            }
            else {
                MessageBox.Show("Please enter an integer value.");

                txtNum1.Clear();
                txtNum1.Focus();
            }
            //2nd box
            if (int.TryParse(txtNum2.Text, out numArray[1])) {
                MessageBox.Show("2nd number of array:  " + numArray[1]);
            }
            else {
                MessageBox.Show("Please enter an integer value.");

                txtNum2.Clear();
                txtNum2.Focus();
            }
            //3rd box
            if (int.TryParse(txtNum3.Text, out numArray[2])) {
                MessageBox.Show("3rd number of array:  " + numArray[2]);
            }
            else {
                MessageBox.Show("Please enter an integer value.");

                txtNum3.Clear();
                txtNum3.Focus();
            }
        }

        private void btnLengthLoop_Click(object sender, EventArgs e) {
            //reassigning an array reference variable
            numArray = new int[4];

            //using the length property
            for (int i = 0; i < numArray.Length; i++) {
                numArray[i] = 99 + i;
            }

            //example of a foreach loop
            foreach (int value in numArray) {
                MessageBox.Show(value.ToString());
            }
        }

        private void btnSaveArrayToFile_Click(object sender, EventArgs e) {
            try {
                StreamWriter fileOut = File.CreateText("Numbers.txt");

                foreach(int value in numArray)
                    fileOut.WriteLine(value);

                //close the files
                fileOut.Close();

                MessageBox.Show("File successfully saved.");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenFileToArray_Click(object sender, EventArgs e) {
            try {
                int[] numA2 = new int[6];
                int i = 0, total = 0;
                double average;

                StreamReader fin = File.OpenText("numbers.txt");

                while(i < numA2.Length && !fin.EndOfStream) {
                    //place into array
                    numA2[i] = int.Parse(fin.ReadLine());
                    total += numA2[i];
                    ++i;
                }

                fin.Close();

                average = total / numA2.Length;

                lbxNumbers2Array.Items.Add("Values");
                ArraysToList(numA2);
                lbxNumbers2Array.Items.Add("Total" + total);
                lbxNumbers2Array.Items.Add("Average" + average);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeqSearch_Click(object sender, EventArgs e) {
            string team = txtTeam.Text;
            string[] tA = {"Cowboys", "Packers", "Raiders", "Cupcakes"};

            if(SequentialSearch(tA, team) != -1)
                MessageBox.Show("In Array");
            else
                MessageBox.Show("NOT In Array");
        }

        private const int MAX_ROWS = 3;
        private const int MAX_COLUMNS = 4;
        double[,] gradesArray = new double[MAX_ROWS, MAX_COLUMNS];
        private int btnClick = 0;

        private void btnEnterGrades_Click(object sender, EventArgs e) {
            if(btnClick < 4) {
                if(btnClick == 0) {
                    gradesArray[0, 0] = int.Parse(txtGd1.Text);
                    gradesArray[1, 0] = int.Parse(txtGd2.Text);
                    gradesArray[2, 0] = int.Parse(txtGd3.Text);
                }
                else if(btnClick == 1) {
                    gradesArray[0, 1] = int.Parse(txtGd1.Text);
                    gradesArray[1, 1] = int.Parse(txtGd2.Text);
                    gradesArray[2, 1] = int.Parse(txtGd3.Text);
                }
                else if(btnClick == 2) {
                    gradesArray[0, 2] = int.Parse(txtGd1.Text);
                    gradesArray[1, 2] = int.Parse(txtGd2.Text);
                    gradesArray[2, 2] = int.Parse(txtGd3.Text);
                }
                else if(btnClick == 3) {
                    gradesArray[0, 3] = int.Parse(txtGd1.Text);
                    gradesArray[1, 3] = int.Parse(txtGd2.Text);
                    gradesArray[2, 3] = int.Parse(txtGd3.Text);
                }
            }
            else
                MessageBox.Show("WRONG");

            ++btnClick;

            txtGd1.Clear();
            txtGd2.Clear();
            txtGd3.Clear();
            txtGd1.Focus();
        }

        private void btnCalcAvg_Click(object sender, EventArgs e) {
            double total, average;

            for(int r = 0; r < MAX_ROWS; ++r) {
                total = 0;
                average = 0;

                for(int c = 0; c < MAX_COLUMNS; ++c)
                    total += gradesArray[r, c];

                average = total / MAX_COLUMNS;

                if(r == 0)
                    lblAvg1.Text = average.ToString();
                else if(r == 1)
                    lblAvg2.Text = average.ToString();
                else if(r == 2)
                    lblAvg3.Text = average.ToString();
            }
        }

        List<string> gNamesList = new List<string>();

        private void btnFileOpenList_Click(object sender, EventArgs e) {
            try {
                StreamReader fileIn = File.OpenText("GirlNames.txt");

                while(!fileIn.EndOfStream)
                    gNamesList.Add(fileIn.ReadLine());

                foreach(string str in gNamesList)
                    lbxGirlNames.Items.Add(str);

                fileIn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            gNamesList.Insert(gNamesList.Count, txtEnterGirlName.Text);
            AppendFile();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            int pos;

            if(lbxGirlNames.SelectedIndex != -1) {
                pos = lbxGirlNames.SelectedIndex;
                gNamesList.RemoveAt(pos);
                lbxGirlNames.Items.RemoveAt(pos);

                MessageBox.Show("DELETED");
            }
            else
                MessageBox.Show("Select name first");
        }

        private void btnExit_Click(object sender, EventArgs e) {
            SaveOnExit();
            Application.Exit();
        }
    }
}
