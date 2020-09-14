namespace lecture3 {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblGPOutput = new System.Windows.Forms.Label();
            this.tbxHoursWorked = new System.Windows.Forms.TextBox();
            this.tbxPayRate = new System.Windows.Forms.TextBox();
            this.btnCalcGP = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTeam = new System.Windows.Forms.Label();
            this.tbxTeam = new System.Windows.Forms.TextBox();
            this.gbxGender = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.cbxBlue = new System.Windows.Forms.CheckBox();
            this.cbxRed = new System.Windows.Forms.CheckBox();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.tbxMonth = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbxPositions = new System.Windows.Forms.ListBox();
            this.gbxGender.SuspendLayout();
            this.pnlColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(25, 22);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(112, 17);
            this.lblHoursWorked.TabIndex = 0;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(57, 73);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(80, 17);
            this.lblPayRate.TabIndex = 1;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(49, 124);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(88, 17);
            this.lblGrossPay.TabIndex = 2;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // lblGPOutput
            // 
            this.lblGPOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGPOutput.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPOutput.Location = new System.Drawing.Point(143, 117);
            this.lblGPOutput.Name = "lblGPOutput";
            this.lblGPOutput.Size = new System.Drawing.Size(118, 30);
            this.lblGPOutput.TabIndex = 3;
            this.lblGPOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHoursWorked
            // 
            this.tbxHoursWorked.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoursWorked.Location = new System.Drawing.Point(143, 19);
            this.tbxHoursWorked.Name = "tbxHoursWorked";
            this.tbxHoursWorked.Size = new System.Drawing.Size(100, 23);
            this.tbxHoursWorked.TabIndex = 4;
            // 
            // tbxPayRate
            // 
            this.tbxPayRate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPayRate.Location = new System.Drawing.Point(143, 70);
            this.tbxPayRate.Name = "tbxPayRate";
            this.tbxPayRate.Size = new System.Drawing.Size(100, 23);
            this.tbxPayRate.TabIndex = 5;
            // 
            // btnCalcGP
            // 
            this.btnCalcGP.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcGP.Location = new System.Drawing.Point(12, 239);
            this.btnCalcGP.Name = "btnCalcGP";
            this.btnCalcGP.Size = new System.Drawing.Size(125, 50);
            this.btnCalcGP.TabIndex = 6;
            this.btnCalcGP.Text = "Calculate &Gross Pay";
            this.btnCalcGP.UseVisualStyleBackColor = true;
            this.btnCalcGP.Click += new System.EventHandler(this.btnCalcGP_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(143, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 50);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(78, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(49, 175);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(88, 17);
            this.lblTeam.TabIndex = 9;
            this.lblTeam.Text = "Team Name:";
            // 
            // tbxTeam
            // 
            this.tbxTeam.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTeam.Location = new System.Drawing.Point(143, 172);
            this.tbxTeam.Name = "tbxTeam";
            this.tbxTeam.Size = new System.Drawing.Size(100, 23);
            this.tbxTeam.TabIndex = 10;
            // 
            // gbxGender
            // 
            this.gbxGender.Controls.Add(this.radMale);
            this.gbxGender.Controls.Add(this.radFemale);
            this.gbxGender.Font = new System.Drawing.Font("Courier New", 10F);
            this.gbxGender.Location = new System.Drawing.Point(315, 19);
            this.gbxGender.Name = "gbxGender";
            this.gbxGender.Size = new System.Drawing.Size(108, 90);
            this.gbxGender.TabIndex = 11;
            this.gbxGender.TabStop = false;
            this.gbxGender.Text = "Gender";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(16, 49);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(58, 21);
            this.radMale.TabIndex = 1;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(16, 22);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(74, 21);
            this.radFemale.TabIndex = 0;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // pnlColor
            // 
            this.pnlColor.Controls.Add(this.cbxBlue);
            this.pnlColor.Controls.Add(this.cbxRed);
            this.pnlColor.Font = new System.Drawing.Font("Courier New", 10F);
            this.pnlColor.Location = new System.Drawing.Point(454, 22);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(104, 87);
            this.pnlColor.TabIndex = 12;
            // 
            // cbxBlue
            // 
            this.cbxBlue.AutoSize = true;
            this.cbxBlue.Location = new System.Drawing.Point(23, 48);
            this.cbxBlue.Name = "cbxBlue";
            this.cbxBlue.Size = new System.Drawing.Size(59, 21);
            this.cbxBlue.TabIndex = 1;
            this.cbxBlue.Text = "Blue";
            this.cbxBlue.UseVisualStyleBackColor = true;
            // 
            // cbxRed
            // 
            this.cbxRed.AutoSize = true;
            this.cbxRed.Location = new System.Drawing.Point(23, 16);
            this.cbxRed.Name = "cbxRed";
            this.cbxRed.Size = new System.Drawing.Size(51, 21);
            this.cbxRed.TabIndex = 0;
            this.cbxRed.Text = "Red";
            this.cbxRed.UseVisualStyleBackColor = true;
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruct.Location = new System.Drawing.Point(280, 161);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(256, 34);
            this.lblInstruct.TabIndex = 13;
            this.lblInstruct.Text = "Enter one of the numbers for\r\nthe first 3 months of the year:";
            // 
            // tbxMonth
            // 
            this.tbxMonth.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMonth.Location = new System.Drawing.Point(373, 198);
            this.tbxMonth.Name = "tbxMonth";
            this.tbxMonth.Size = new System.Drawing.Size(50, 23);
            this.tbxMonth.TabIndex = 14;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(342, 264);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(125, 50);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "O&K";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbxPositions
            // 
            this.lbxPositions.Font = new System.Drawing.Font("Courier New", 10F);
            this.lbxPositions.FormattingEnabled = true;
            this.lbxPositions.ItemHeight = 16;
            this.lbxPositions.Items.AddRange(new object[] {
            "full-time",
            "part-time"});
            this.lbxPositions.Location = new System.Drawing.Point(591, 22);
            this.lbxPositions.Name = "lbxPositions";
            this.lbxPositions.Size = new System.Drawing.Size(120, 84);
            this.lbxPositions.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 365);
            this.Controls.Add(this.lbxPositions);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxMonth);
            this.Controls.Add(this.lblInstruct);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.gbxGender);
            this.Controls.Add(this.tbxTeam);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcGP);
            this.Controls.Add(this.tbxPayRate);
            this.Controls.Add(this.tbxHoursWorked);
            this.Controls.Add(this.lblGPOutput);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblHoursWorked);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture 3";
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
            this.pnlColor.ResumeLayout(false);
            this.pnlColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblGPOutput;
        private System.Windows.Forms.TextBox tbxHoursWorked;
        private System.Windows.Forms.TextBox tbxPayRate;
        private System.Windows.Forms.Button btnCalcGP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.TextBox tbxTeam;
        private System.Windows.Forms.GroupBox gbxGender;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.CheckBox cbxBlue;
        private System.Windows.Forms.CheckBox cbxRed;
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.TextBox tbxMonth;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox lbxPositions;
    }
}

