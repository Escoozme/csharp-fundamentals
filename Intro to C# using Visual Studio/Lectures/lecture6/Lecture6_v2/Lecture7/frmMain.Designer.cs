namespace Lecture7
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetEachElement = new System.Windows.Forms.Button();
            this.lblArrays = new System.Windows.Forms.Label();
            this.lblInstr1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.btnTxtElement = new System.Windows.Forms.Button();
            this.btnLengthLoop = new System.Windows.Forms.Button();
            this.btnSaveArrayToFile = new System.Windows.Forms.Button();
            this.btnOpenFileToArray = new System.Windows.Forms.Button();
            this.lbxNumbers2Array = new System.Windows.Forms.ListBox();
            this.btnSeqSearch = new System.Windows.Forms.Button();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblGrades = new System.Windows.Forms.Label();
            this.lblStud1 = new System.Windows.Forms.Label();
            this.lblStud2 = new System.Windows.Forms.Label();
            this.lblStud3 = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.txtGd1 = new System.Windows.Forms.TextBox();
            this.txtGd2 = new System.Windows.Forms.TextBox();
            this.txtGd3 = new System.Windows.Forms.TextBox();
            this.btnEnterGrades = new System.Windows.Forms.Button();
            this.lblAvg1 = new System.Windows.Forms.Label();
            this.lblAvg2 = new System.Windows.Forms.Label();
            this.lblAvg3 = new System.Windows.Forms.Label();
            this.btnCalcAvg = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtEnterGirlName = new System.Windows.Forms.TextBox();
            this.btnFileOpenList = new System.Windows.Forms.Button();
            this.lbxGirlNames = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetEachElement
            // 
            this.btnSetEachElement.Location = new System.Drawing.Point(24, 100);
            this.btnSetEachElement.Margin = new System.Windows.Forms.Padding(5);
            this.btnSetEachElement.Name = "btnSetEachElement";
            this.btnSetEachElement.Size = new System.Drawing.Size(174, 76);
            this.btnSetEachElement.TabIndex = 0;
            this.btnSetEachElement.Text = "Set Each Element\r\nof Array";
            this.btnSetEachElement.UseVisualStyleBackColor = true;
            this.btnSetEachElement.Click += new System.EventHandler(this.btnSetEachElement_Click);
            // 
            // lblArrays
            // 
            this.lblArrays.AutoSize = true;
            this.lblArrays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblArrays.Location = new System.Drawing.Point(354, 34);
            this.lblArrays.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblArrays.Name = "lblArrays";
            this.lblArrays.Size = new System.Drawing.Size(178, 23);
            this.lblArrays.TabIndex = 1;
            this.lblArrays.Text = "Array Type Examples";
            // 
            // lblInstr1
            // 
            this.lblInstr1.AutoSize = true;
            this.lblInstr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblInstr1.Location = new System.Drawing.Point(20, 228);
            this.lblInstr1.Name = "lblInstr1";
            this.lblInstr1.Size = new System.Drawing.Size(182, 46);
            this.lblInstr1.TabIndex = 2;
            this.lblInstr1.Text = "Enter integers in the \r\ntext boxes below:";
            this.lblInstr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(28, 277);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(170, 30);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(28, 313);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(170, 30);
            this.txtNum2.TabIndex = 4;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(28, 349);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(170, 30);
            this.txtNum3.TabIndex = 5;
            // 
            // btnTxtElement
            // 
            this.btnTxtElement.Location = new System.Drawing.Point(12, 385);
            this.btnTxtElement.Name = "btnTxtElement";
            this.btnTxtElement.Size = new System.Drawing.Size(201, 80);
            this.btnTxtElement.TabIndex = 6;
            this.btnTxtElement.Text = "Set Each Element of\r\nArray with Text Box\r\nInformation";
            this.btnTxtElement.UseVisualStyleBackColor = true;
            this.btnTxtElement.Click += new System.EventHandler(this.btnTxtElement_Click);
            // 
            // btnLengthLoop
            // 
            this.btnLengthLoop.Location = new System.Drawing.Point(12, 480);
            this.btnLengthLoop.Name = "btnLengthLoop";
            this.btnLengthLoop.Size = new System.Drawing.Size(216, 149);
            this.btnLengthLoop.TabIndex = 7;
            this.btnLengthLoop.Text = "Step thru an Array \r\nusing the Length\r\nProperty, foreach loop,\r\nReassigning the A" +
    "rray \r\nReference Variable";
            this.btnLengthLoop.UseVisualStyleBackColor = true;
            this.btnLengthLoop.Click += new System.EventHandler(this.btnLengthLoop_Click);
            // 
            // btnSaveArrayToFile
            // 
            this.btnSaveArrayToFile.Location = new System.Drawing.Point(239, 94);
            this.btnSaveArrayToFile.Name = "btnSaveArrayToFile";
            this.btnSaveArrayToFile.Size = new System.Drawing.Size(141, 88);
            this.btnSaveArrayToFile.TabIndex = 8;
            this.btnSaveArrayToFile.Text = "Save Array \r\nElements to \r\na File";
            this.btnSaveArrayToFile.UseVisualStyleBackColor = true;
            this.btnSaveArrayToFile.Click += new System.EventHandler(this.btnSaveArrayToFile_Click);
            // 
            // btnOpenFileToArray
            // 
            this.btnOpenFileToArray.Location = new System.Drawing.Point(534, 94);
            this.btnOpenFileToArray.Name = "btnOpenFileToArray";
            this.btnOpenFileToArray.Size = new System.Drawing.Size(141, 88);
            this.btnOpenFileToArray.TabIndex = 9;
            this.btnOpenFileToArray.Text = "Open File and\r\nPlace Values in\r\nan Array";
            this.btnOpenFileToArray.UseVisualStyleBackColor = true;
            this.btnOpenFileToArray.Click += new System.EventHandler(this.btnOpenFileToArray_Click);
            // 
            // lbxNumbers2Array
            // 
            this.lbxNumbers2Array.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNumbers2Array.FormattingEnabled = true;
            this.lbxNumbers2Array.ItemHeight = 16;
            this.lbxNumbers2Array.Location = new System.Drawing.Point(239, 197);
            this.lbxNumbers2Array.Name = "lbxNumbers2Array";
            this.lbxNumbers2Array.Size = new System.Drawing.Size(593, 276);
            this.lbxNumbers2Array.TabIndex = 10;
            // 
            // btnSeqSearch
            // 
            this.btnSeqSearch.Location = new System.Drawing.Point(268, 576);
            this.btnSeqSearch.Name = "btnSeqSearch";
            this.btnSeqSearch.Size = new System.Drawing.Size(157, 48);
            this.btnSeqSearch.TabIndex = 11;
            this.btnSeqSearch.Text = "Sequential Search";
            this.btnSeqSearch.UseVisualStyleBackColor = true;
            this.btnSeqSearch.Click += new System.EventHandler(this.btnSeqSearch_Click);
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(239, 540);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(212, 30);
            this.txtTeam.TabIndex = 12;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BackColor = System.Drawing.Color.Lime;
            this.lblTeamName.Location = new System.Drawing.Point(235, 491);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(216, 46);
            this.lblTeamName.TabIndex = 13;
            this.lblTeamName.Text = "Enter a Team Name below\r\nto see if in the League?";
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.BackColor = System.Drawing.Color.Fuchsia;
            this.lblGrades.Location = new System.Drawing.Point(475, 491);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(193, 23);
            this.lblGrades.TabIndex = 14;
            this.lblGrades.Text = "Three Students Grades";
            // 
            // lblStud1
            // 
            this.lblStud1.AutoSize = true;
            this.lblStud1.Location = new System.Drawing.Point(479, 530);
            this.lblStud1.Name = "lblStud1";
            this.lblStud1.Size = new System.Drawing.Size(95, 23);
            this.lblStud1.TabIndex = 15;
            this.lblStud1.Text = "Student 1:";
            // 
            // lblStud2
            // 
            this.lblStud2.AutoSize = true;
            this.lblStud2.Location = new System.Drawing.Point(479, 566);
            this.lblStud2.Name = "lblStud2";
            this.lblStud2.Size = new System.Drawing.Size(95, 23);
            this.lblStud2.TabIndex = 16;
            this.lblStud2.Text = "Student 2:";
            // 
            // lblStud3
            // 
            this.lblStud3.AutoSize = true;
            this.lblStud3.Location = new System.Drawing.Point(479, 601);
            this.lblStud3.Name = "lblStud3";
            this.lblStud3.Size = new System.Drawing.Size(95, 23);
            this.lblStud3.TabIndex = 17;
            this.lblStud3.Text = "Student 3:";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.BackColor = System.Drawing.Color.Fuchsia;
            this.lblAvg.Location = new System.Drawing.Point(696, 491);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(89, 23);
            this.lblAvg.TabIndex = 18;
            this.lblAvg.Text = "Averages:";
            // 
            // txtGd1
            // 
            this.txtGd1.Location = new System.Drawing.Point(575, 523);
            this.txtGd1.Name = "txtGd1";
            this.txtGd1.Size = new System.Drawing.Size(48, 30);
            this.txtGd1.TabIndex = 19;
            // 
            // txtGd2
            // 
            this.txtGd2.Location = new System.Drawing.Point(575, 563);
            this.txtGd2.Name = "txtGd2";
            this.txtGd2.Size = new System.Drawing.Size(48, 30);
            this.txtGd2.TabIndex = 22;
            // 
            // txtGd3
            // 
            this.txtGd3.Location = new System.Drawing.Point(575, 601);
            this.txtGd3.Name = "txtGd3";
            this.txtGd3.Size = new System.Drawing.Size(48, 30);
            this.txtGd3.TabIndex = 25;
            // 
            // btnEnterGrades
            // 
            this.btnEnterGrades.Location = new System.Drawing.Point(483, 646);
            this.btnEnterGrades.Name = "btnEnterGrades";
            this.btnEnterGrades.Size = new System.Drawing.Size(75, 55);
            this.btnEnterGrades.TabIndex = 26;
            this.btnEnterGrades.Text = "Enter Grades";
            this.btnEnterGrades.UseVisualStyleBackColor = true;
            this.btnEnterGrades.Click += new System.EventHandler(this.btnEnterGrades_Click);
            // 
            // lblAvg1
            // 
            this.lblAvg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvg1.Location = new System.Drawing.Point(700, 529);
            this.lblAvg1.Name = "lblAvg1";
            this.lblAvg1.Size = new System.Drawing.Size(85, 30);
            this.lblAvg1.TabIndex = 27;
            // 
            // lblAvg2
            // 
            this.lblAvg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvg2.Location = new System.Drawing.Point(700, 565);
            this.lblAvg2.Name = "lblAvg2";
            this.lblAvg2.Size = new System.Drawing.Size(85, 30);
            this.lblAvg2.TabIndex = 28;
            // 
            // lblAvg3
            // 
            this.lblAvg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvg3.Location = new System.Drawing.Point(700, 603);
            this.lblAvg3.Name = "lblAvg3";
            this.lblAvg3.Size = new System.Drawing.Size(85, 30);
            this.lblAvg3.TabIndex = 29;
            // 
            // btnCalcAvg
            // 
            this.btnCalcAvg.Location = new System.Drawing.Point(688, 646);
            this.btnCalcAvg.Name = "btnCalcAvg";
            this.btnCalcAvg.Size = new System.Drawing.Size(117, 55);
            this.btnCalcAvg.TabIndex = 30;
            this.btnCalcAvg.Text = "Calculate Averages";
            this.btnCalcAvg.UseVisualStyleBackColor = true;
            this.btnCalcAvg.Click += new System.EventHandler(this.btnCalcAvg_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblList.Location = new System.Drawing.Point(41, 14);
            this.lblList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(123, 23);
            this.lblList.TabIndex = 31;
            this.lblList.Text = "List  Examples";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.btnDelete);
            this.pnlList.Controls.Add(this.btnInsert);
            this.pnlList.Controls.Add(this.txtEnterGirlName);
            this.pnlList.Controls.Add(this.btnFileOpenList);
            this.pnlList.Controls.Add(this.lbxGirlNames);
            this.pnlList.Controls.Add(this.lblList);
            this.pnlList.Location = new System.Drawing.Point(898, 113);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(224, 482);
            this.pnlList.TabIndex = 32;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 57);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(22, 400);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 57);
            this.btnInsert.TabIndex = 35;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtEnterGirlName
            // 
            this.txtEnterGirlName.Location = new System.Drawing.Point(22, 367);
            this.txtEnterGirlName.Name = "txtEnterGirlName";
            this.txtEnterGirlName.Size = new System.Drawing.Size(175, 30);
            this.txtEnterGirlName.TabIndex = 34;
            // 
            // btnFileOpenList
            // 
            this.btnFileOpenList.Location = new System.Drawing.Point(22, 288);
            this.btnFileOpenList.Name = "btnFileOpenList";
            this.btnFileOpenList.Size = new System.Drawing.Size(175, 64);
            this.btnFileOpenList.TabIndex = 33;
            this.btnFileOpenList.Text = "Open File Place\r\nin List and List Box";
            this.btnFileOpenList.UseVisualStyleBackColor = true;
            this.btnFileOpenList.Click += new System.EventHandler(this.btnFileOpenList_Click);
            // 
            // lbxGirlNames
            // 
            this.lbxGirlNames.FormattingEnabled = true;
            this.lbxGirlNames.ItemHeight = 23;
            this.lbxGirlNames.Location = new System.Drawing.Point(22, 55);
            this.lbxGirlNames.Name = "lbxGirlNames";
            this.lbxGirlNames.Size = new System.Drawing.Size(175, 211);
            this.lbxGirlNames.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1047, 646);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 57);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 738);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnCalcAvg);
            this.Controls.Add(this.lblAvg3);
            this.Controls.Add(this.lblAvg2);
            this.Controls.Add(this.lblAvg1);
            this.Controls.Add(this.btnEnterGrades);
            this.Controls.Add(this.txtGd3);
            this.Controls.Add(this.txtGd2);
            this.Controls.Add(this.txtGd1);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblStud3);
            this.Controls.Add(this.lblStud2);
            this.Controls.Add(this.lblStud1);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.btnSeqSearch);
            this.Controls.Add(this.lbxNumbers2Array);
            this.Controls.Add(this.btnOpenFileToArray);
            this.Controls.Add(this.btnSaveArrayToFile);
            this.Controls.Add(this.btnLengthLoop);
            this.Controls.Add(this.btnTxtElement);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblInstr1);
            this.Controls.Add(this.lblArrays);
            this.Controls.Add(this.btnSetEachElement);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module 6 Lecture";
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetEachElement;
        private System.Windows.Forms.Label lblArrays;
        private System.Windows.Forms.Label lblInstr1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button btnTxtElement;
        private System.Windows.Forms.Button btnLengthLoop;
        private System.Windows.Forms.Button btnSaveArrayToFile;
        private System.Windows.Forms.Button btnOpenFileToArray;
        private System.Windows.Forms.ListBox lbxNumbers2Array;
        private System.Windows.Forms.Button btnSeqSearch;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Label lblStud1;
        private System.Windows.Forms.Label lblStud2;
        private System.Windows.Forms.Label lblStud3;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.TextBox txtGd1;
        private System.Windows.Forms.TextBox txtGd2;
        private System.Windows.Forms.TextBox txtGd3;
        private System.Windows.Forms.Button btnEnterGrades;
        private System.Windows.Forms.Label lblAvg1;
        private System.Windows.Forms.Label lblAvg2;
        private System.Windows.Forms.Label lblAvg3;
        private System.Windows.Forms.Button btnCalcAvg;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.ListBox lbxGirlNames;
        private System.Windows.Forms.Button btnFileOpenList;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtEnterGirlName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}

